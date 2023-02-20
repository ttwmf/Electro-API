namespace ElectroECommerce.Application.Models.Dtos
{
    public class DtoCustomer : DtoBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
