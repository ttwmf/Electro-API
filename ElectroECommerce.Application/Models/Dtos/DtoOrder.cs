namespace ElectroECommerce.Application.Models.Dtos
{
    public class DtoOrder : DtoBase
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
        public DtoCustomer Customer { get; set; }

        public ICollection<DtoOrderDetail> OrderDetails { get; set; }
    }
}
