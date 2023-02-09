using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Order : BaseEntity
    {
        public string OrderCode { get; set; }
        
        public Customer Customer { get; set; }

        public decimal TotalAmount { get; set; }

        public int TotalItem { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
