using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Promotion : BaseEntity
    {
        public string PromotionName { get; set; }
        public string Description { get; set; }

        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }

    }
}
