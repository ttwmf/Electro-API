namespace ElectroECommerce.Application.Models.Request
{
    public class CreateSupplierRequest
    {
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
