namespace ElectroECommerce.Domain
{
    public class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public int TotalItems { get; set; }
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Customer navigation property
        /// </summary>
        public Customer Customer { get; set; }

        public virtual ICollection<CartDetails> CartDetails { get; set; }
    }
}
