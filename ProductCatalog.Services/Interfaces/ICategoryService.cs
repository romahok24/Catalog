using ProductCatalog.DTO;
using ProductCatalog.DTO.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCatalog.Services.Interfaces
{
    public interface ICategoryService
    {
        OperationResponse<CategoryDTO> Read(int id);
        OperationResponse<IEnumerable<CategoryDTO>> Read();
        Task<OperationResponse<CategoryDTO>> Create(CategoryDTO dto);
        Task<OperationResponse<CategoryDTO>> Update(CategoryDTO dto);
        Task<OperationResponse<CategoryDTO>> Delete(int id);
    }
}
