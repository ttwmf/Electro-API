using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Domain
{
    public class Specifications : BaseEntity 
    {
        public string CPU { get; set; }
        public int RAM { get; set; }

        public int Storage { get; set; }
        public double MonitorSize { get; set; }

        public double Weight { get; set; }

        public string VGA { get; set; }


    }
}
