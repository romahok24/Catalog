using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Domain.Models;
using ProductCatalog.DTO.DTO;
using ProductCatalog.DTO.Infrastructure;
using ProductCatalog.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.Services.Services
{
    public class AdminService : BaseService, IAdminService
    {
        public AdminService(IUnitOfWork database, IMapper mapper) : base(database, mapper)
        {
        }

        public async Task<OperationResponse<UserDTO>> Create(UserDTO model)
        {
            var userModel = _mapper.Map<User>(model);
            userModel.Id = Guid.NewGuid().ToString();

            var result = await _database.UserManager.CreateAsync(userModel, model.Password);

            if (!result.Succeeded)
            {
                var errorString = ErrorMessages.CreateFailed + string.Join(", ", result.Errors);
                return new OperationResponse<UserDTO>(false, errorString);
            }

            var roleResult = await _database.UserManager.AddToRoleAsync(userModel, model.Role);

            if (!roleResult.Succeeded)
            {
                var errorString = ErrorMessages.AddingRoleFailed + string.Join(", ", result.Errors);
                return new OperationResponse<UserDTO>(false, errorString);
            }

            await _database.SaveAsync();

            return new OperationResponse<UserDTO>(true, SuccessMessages.Created);
        }

        public async Task<OperationResponse<UserDTO>> Delete(string id)
        {
            var user = await _database.UserManager.FindByIdAsync(id);

            if (user == null)
            {
                return new OperationResponse<UserDTO>(false, ErrorMessages.NotFound);
            }

            var result = await _database.UserManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                var errorString = ErrorMessages.DeleteFailed + string.Join(", ", result.Errors);
                return new OperationResponse<UserDTO>(false, errorString);
            }

            return new OperationResponse<UserDTO>(true, SuccessMessages.Deleted);
        }

        public async Task<OperationResponse<IEnumerable<UserDTO>>> Read()
        {
            try
            {
                var models = new List<UserDTO>();
                var users = await _database.UserManager.Users.ToListAsync();

                foreach (var user in users)
                {
                    var dto = _mapper.Map<UserDTO>(user);
                    dto.Role = (await _database.UserManager.GetRolesAsync(user)).FirstOrDefault();
                    models.Add(dto);
                }

                var successDetails = new OperationDetails(true, SuccessMessages.Retrived);
                return new OperationResponse<IEnumerable<UserDTO>>(true, SuccessMessages.Retrived, models);
            }
            catch (Exception ex)
            {
                return new OperationResponse<IEnumerable<UserDTO>>(false, ErrorMessages.ReadFailed + ex.Message);
            }
        }

        public async Task<OperationResponse<UserDTO>> Read(string id)
        {
            try
            {
                var user = await _database.UserManager.FindByIdAsync(id);

                if (user == null)
                {
                    return new OperationResponse<UserDTO>(false, ErrorMessages.NotFound);
                }

                var dto = _mapper.Map<UserDTO>(user);
                dto.Role = (await _database.UserManager.GetRolesAsync(user)).FirstOrDefault();

                return new OperationResponse<UserDTO>(true, SuccessMessages.Retrived, dto);
            }
            catch (Exception ex)
            {
                return new OperationResponse<UserDTO>(false, ErrorMessages.ReadFailed + ex.Message);
            }
        }

        public async Task<OperationResponse<UserDTO>> BlockUser(string id)
        {
            try
            {
                var user = await _database.UserManager.FindByIdAsync(id);

                if (user == null)
                {
                    return new OperationResponse<UserDTO>(false, ErrorMessages.NotFound);
                }

                user.IsBlocked = true;
                var updateResult = await _database.UserManager.UpdateAsync(user);

                if (!updateResult.Succeeded)
                {
                    var errorMessage =  ErrorMessages.BlockingUserFailed + string.Join(", ", updateResult.Errors);
                    return new OperationResponse<UserDTO>(false, errorMessage);
                }

                return new OperationResponse<UserDTO>(true, SuccessMessages.Blocked);
            }
            catch (Exception ex)
            {
                return new OperationResponse<UserDTO>(false, ErrorMessages.BlockingUserFailed + ex.Message);
            }
        }

        public async Task<OperationResponse<UserDTO>> UpdatePassword(ChangePasswordDTO model)
        {
            try
            {
                var user = await _database.UserManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    return new OperationResponse<UserDTO>(false, ErrorMessages.NotFound);
                }

                var token = await _database.UserManager.GeneratePasswordResetTokenAsync(user);
                var updateResult = await _database.UserManager.ResetPasswordAsync(user, token, model.Password);

                if (!updateResult.Succeeded)
                {
                    var errorMessages = ErrorMessages.UpdateFailed + string.Join(", ", updateResult.Errors);
                    return new OperationResponse<UserDTO>(false, errorMessages);
                }

                return new OperationResponse<UserDTO>(true, SuccessMessages.Updated);
            }
            catch (Exception ex)
            {
                return new OperationResponse<UserDTO>(false, ErrorMessages.UpdateFailed + ex.Message);
            }
        }

        public async Task<OperationResponse<IEnumerable<string>>> GetAllRoles()
        {
            try
            {
                var roles = await _database.RoleManager.Roles.Select(r => r.Name).ToListAsync();
                return new OperationResponse<IEnumerable<string>>(true, SuccessMessages.Retrived, roles);
            }
            catch (Exception ex)
            {
                return new OperationResponse<IEnumerable<string>>(false, ErrorMessages.ReadFailed + ex.Message);
            }
        }
    }
}