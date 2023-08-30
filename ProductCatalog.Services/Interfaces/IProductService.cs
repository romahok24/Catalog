using ProductCatalog.DTO;
using ProductCatalog.DTO.DTO;
using ProductCatalog.DTO.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCatalog.Services.Interfaces
{
    public interface IProductService
    {
        OperationResponse<ProductDTO> Read(int id);
        OperationResponse<IEnumerable<ProductDTO>> Read();
        IEnumerable<ProductDTO> Read(ProductFilterDTO filter);
        Task<OperationResponse<ProductDTO>> Create(ProductDTO dto);
        Task<OperationResponse<ProductDTO>> Update(ProductDTO dto);
        Task<OperationResponse<ProductDTO>> Delete(int id);
    }
}