using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class UpdateImageRequest 
    {
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Status { get; set; }
    }
}
