namespace ElectroECommerce.Domain
{
    public class Voucher : BaseEntity
    {
        public string VoucherName { get; set; }
        public string VoucherCode { get; set; }
        public string ImageUrl { get; set; }
        public int DiscountType { get; set; }
        public double DiscountPercent { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}
