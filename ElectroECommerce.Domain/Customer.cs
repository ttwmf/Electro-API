namespace ElectroECommerce.Domain
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
    }
}
