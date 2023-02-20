namespace ElectroECommerce.Domain
{
    public class PromotionDetail : BaseEntity
    {
        public int PromotionId { get; set; }
        public int ProductId { get; set; }
        public decimal? DiscountPrice { get; set; }
        public double? DiscountPercent { get; set; }
        public int DiscountType { get; set; }

        public Product Product { get; set; }
    }
}
