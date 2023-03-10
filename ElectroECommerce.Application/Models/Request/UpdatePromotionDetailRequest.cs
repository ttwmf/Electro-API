using System.ComponentModel.DataAnnotations;

namespace ElectroECommerce.Application.Models.Request
{
    public class UpdatePromotionDetailRequest
    {
        [Required]
        public int PromotionId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal? DiscountPrice { get; set; }
        [Required]
        public double? DiscountPercent { get; set; }
        [Required]
        public int DiscountType { get; set; }
    }
}
