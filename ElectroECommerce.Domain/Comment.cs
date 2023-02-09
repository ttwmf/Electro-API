using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int ProductId { get; set; }
        public Customer Customer { get; set; }
        public int Rating { get; set; }
    }
}
