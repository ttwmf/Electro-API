namespace ElectroECommerce.Domain
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
        /// <summary>
        /// Product navigation property
        /// </summary>
        public Product Product { get; set; }

    }
}
