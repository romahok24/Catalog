using AutoMapper;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Domain.Models;
using ProductCatalog.DTO;
using ProductCatalog.DTO.Infrastructure;
using ProductCatalog.Services.Interfaces;
using ProductCatalog.Utils.JWT;
using System.Linq;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.Services.Services
{
    public class AuthentificationService : BaseService, IAuthentificationService
    {
        public AuthentificationService(IUnitOfWork database, IMapper mapper) : base(database, mapper)
        {
        }

        public async Task<OperationResponse<AuthentificationDetails>> Authentificate(AuthentificationModelDTO model)
        {
            var managedUser = await _database.UserManager.FindByEmailAsync(model.Email);
            if (managedUser == null)
            {
                return new OperationResponse<AuthentificationDetails>(false, ErrorMessages.UserWithEmailNotFound);
            }

            var isPasswordValid = await _database.UserManager.CheckPasswordAsync(managedUser, model.Password);
            if (!isPasswordValid)
            {
                return new OperationResponse<AuthentificationDetails>(false, ErrorMessages.InvalidPassword);
            }

            if (managedUser.IsBlocked)
            {
                return new OperationResponse<AuthentificationDetails>(false, ErrorMessages.UserBlocked);
            }

            var roles = await _database.UserManager.GetRolesAsync(managedUser);

            if (!roles.Any())
            {
                return new OperationResponse<AuthentificationDetails>(false, ErrorMessages.NoRoles);
            }

            var accessToken = TokenHelper.CreateToken(managedUser, roles.FirstOrDefault());
            await _database.SaveAsync();

            var authDetails = new AuthentificationDetails
            {
                Username = managedUser.UserName,
                Email = managedUser.Email,
                Token = accessToken,
                Role = roles.FirstOrDefault(),
            };

            return new OperationResponse<AuthentificationDetails>(true, SuccessMessages.Logined, authDetails);
        }

        public async Task<OperationResponse<RegistrationModelDTO>> Register(RegistrationModelDTO model)
        {
            var userModel = _mapper.Map<User>(model);

            var existingUser = await _database.UserManager.FindByNameAsync(model.UserName);
            if (existingUser != null)
            {
                var response = new OperationResponse<RegistrationModelDTO>(false, ErrorMessages.UserNameExists);
                return response;
            }

            var result = await _database.UserManager.CreateAsync(userModel, model.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(error => error.Description));
                var response = new OperationResponse<RegistrationModelDTO>(false, ErrorMessages.CreateFailed + errors);
                return response;
            }

            var role = await _database.UserManager.AddToRoleAsync(userModel, Roles.User);

            model.Password = string.Empty;
            await _database.SaveAsync();

            var successResponse = new OperationResponse<RegistrationModelDTO>(true, SuccessMessages.Registred);

            return successResponse;
        }
    }
}
