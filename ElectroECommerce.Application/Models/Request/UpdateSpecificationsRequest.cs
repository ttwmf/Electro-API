using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models.Request
{
    public class UpdateSpecificationsRequest
    {
        [Required]
        public string CPU { get; set; }
        [Required]
        public string RAM { get; set; }
        [Required]
        public string VGA { get; set; }
        [Required]
        public string Storage { get; set; }
        [Required]
        public string MonitorSize { get; set; }
        [Required]
        public string Weight { get; set; }
    }
}
