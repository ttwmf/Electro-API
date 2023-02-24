using System.ComponentModel.DataAnnotations;

namespace ElectroECommerce.Application.Models.Request
{
    public class UpdateSupplierRequest
    {
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
