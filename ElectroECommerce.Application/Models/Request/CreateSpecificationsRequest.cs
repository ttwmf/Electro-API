using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class CreateSpecificationsRequest
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string VGA { get; set; }
        public string Storage { get; set; }
        public string MonitorSize { get; set; }
        public string Weight { get; set; }
    }
}
