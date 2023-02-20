namespace ElectroECommerce.Domain
{
    public class CartDetails : BaseEntity
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Product navigation property
        /// </summary>
        public Product Product { get; set; }
    }
}
