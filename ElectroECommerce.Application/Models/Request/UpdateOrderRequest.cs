using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class UpdateOrderRequest
    {
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public decimal ShippingCost { get; set; }
        [Required]
        public int PaymentMethod { get; set; }
        [Required]
        public int TotalItems { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public decimal TotalDiscount { get; set; }
        [Required]
        public string VoucherCode { get; set; }
    }
}
