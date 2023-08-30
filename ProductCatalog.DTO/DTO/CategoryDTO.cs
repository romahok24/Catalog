using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.DTO
{
    public class CategoryDTO : BaseDTO
    {
        [Display(Name = "Название категории")]
        public string Name { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
