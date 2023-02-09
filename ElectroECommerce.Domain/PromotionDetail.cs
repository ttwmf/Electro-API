using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class PromotionDetail : BaseEntity
    {
        public Product Product { get; set; }

        /// <summary>
        /// Promotion Type ( 1 = %, 2 = concrete, 3 = gift) 
        /// </summary>
        public int Type { get; set; }

        public decimal DiscountPrice { get; set; }

        public int? Percent { get; set; }

        public decimal Descrease { get; set; }
    }
}
