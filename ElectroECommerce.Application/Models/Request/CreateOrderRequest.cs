using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class CreateOrderRequest
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

    }
}
