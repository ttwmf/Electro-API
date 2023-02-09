namespace ElectroECommerce.Domain
{
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Type { get; set; }

        public string Description { get; set; }

        public Image Image { get; set; }

        public Specifications Specifications { get; set; }

        public int QuantityInStock { get; set; }

        public int QuantitySold { get; set; }

        public int NumberOfView { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
