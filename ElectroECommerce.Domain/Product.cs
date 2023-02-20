namespace ElectroECommerce.Domain
{
    public class Product : BaseEntity
    {
        public int SupplierId { get; set; }
        public int SpecificationsId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityInStock { get; set; }
        public int QuantitySold { get; set; }
        public int TotalViews { get; set; }

        // Navigation properties
        public Supplier Supplier { get; set; }
        public Specifications Specifications { get; set; }

    }
}
