using ProductCatalog.DTO;
using ProductCatalog.DTO.Infrastructure;
using System.Threading.Tasks;

namespace ProductCatalog.Services.Interfaces
{
    public interface IAuthentificationService
    {
        Task<OperationResponse<AuthentificationDetails>> Authentificate(AuthentificationModelDTO model);
        Task<OperationResponse<RegistrationModelDTO>> Register(RegistrationModelDTO model);
    }
}
