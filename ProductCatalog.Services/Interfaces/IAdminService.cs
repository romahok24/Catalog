using Microsoft.AspNetCore.Identity;
using ProductCatalog.DTO.DTO;
using ProductCatalog.DTO.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCatalog.Services.Interfaces
{
    public interface IAdminService
    {
        Task<OperationResponse<UserDTO>> Create(UserDTO model);
        Task<OperationResponse<UserDTO>> Delete(string id);
        Task<OperationResponse<IEnumerable<UserDTO>>> Read();
        Task<OperationResponse<UserDTO>> Read(string id);
        Task<OperationResponse<UserDTO>> UpdatePassword(ChangePasswordDTO model);
        Task<OperationResponse<UserDTO>> BlockUser(string id);
        Task<OperationResponse<IEnumerable<string>>> GetAllRoles();
    }
}
