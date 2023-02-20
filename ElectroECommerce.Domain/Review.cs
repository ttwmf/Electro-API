using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Review : BaseEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public int RatingPoint { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
