﻿namespace ElectroECommerce.Domain
{
    public class Supplier : BaseEntity
    {
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
