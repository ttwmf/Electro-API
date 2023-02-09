namespace ElectroECommerce.Domain
{
    public class OrderDetail : BaseEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
    }
}
