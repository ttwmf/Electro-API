using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Image : BaseEntity
    {
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }
}
