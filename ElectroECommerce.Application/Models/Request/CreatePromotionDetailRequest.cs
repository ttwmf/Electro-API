using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class CreatePromotionDetailRequest
    {
        public int PromotionId { get; set; }
        public int ProductId { get; set; }
        public decimal? DiscountPrice { get; set; }
        public double? DiscountPercent { get; set; }
        public int DiscountType { get; set; }
    }
}
