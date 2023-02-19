using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class CreateImageRequest
    {
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }
}
