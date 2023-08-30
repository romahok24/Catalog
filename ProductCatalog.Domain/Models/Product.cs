namespace ProductCatalog.Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Cost { get; set; }

        public string GeneralNote { get; set; }

        public string SpecialNote { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}