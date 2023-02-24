namespace ElectroECommerce.Domain
{
    public class Order : BaseEntity
    {
        public string OrderCode { get; set; }
        public int CustomerId { get; set; }
        public string ShippingAddress { get; set; }
        public decimal ShippingCost { get; set; }
        public int PaymentMethod { get; set; }
        public int TotalItems { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public string VoucherCode { get; set; }

        /// <summary>
        /// Customer navigation property
        /// </summary>
        public Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
