using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProductCatalog.DTO.DTO
{
    public class ProductFilterDTO
    {
        [Display(Name = "Наименование продукта")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Стоимость от")]
        public double? PriceFrom { get; set; }

        [Display(Name = "Стоимость до")]
        public double? PriceTo { get; set; }

        [Display(Name = "Примечание общее")]
        public string GeneralNote { get; set; }

        [Display(Name = "Примечание специальное")]
        public string SpecialNote { get; set; }
        [Display(Name = "Категория")]
        public int? CategoryId { get; set; }

    }
}
