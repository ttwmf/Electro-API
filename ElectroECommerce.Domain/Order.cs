using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string ShippingAddres { get; set; }
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
