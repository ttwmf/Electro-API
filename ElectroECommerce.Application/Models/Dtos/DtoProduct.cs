using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Dtos
{
    public class DtoProduct : DtoBase
    {
        public int SupplierId { get; set; }
        public int SpecificationsId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityInStock { get; set; }
        public int QuantitySold { get; set; }
        public int TotalViews { get; set; }

        // Navigation properties
        public DtoSupplier Supplier { get; set; }
        public DtoSpecifications Specifications { get; set; }
    }
}
