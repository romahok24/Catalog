using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.DTO
{
    public class ProductDTO : BaseDTO
    {
        [Required]
        [Display(Name = "Наименование продукта")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Стоимость в рублях")]
        public double Cost { get; set; }

        [Required]
        [Display(Name = "Примечание общее")]
        public string GeneralNote { get; set; }

        [Display(Name = "Примечание специальное")]
        public string SpecialNote { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}