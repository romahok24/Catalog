using ProductCatalog.DTO;
using ProductCatalog.DTO.DTO;
using System.Collections.Generic;

namespace ProductCatalog.Client.Models
{
    public class ProductViewModel
    {
        public ProductFilterDTO Filter { get; set; }
        public IEnumerable<CategoryDTO> Categories { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
