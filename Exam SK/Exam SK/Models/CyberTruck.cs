using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class CyberTruck
{
        
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Model { get; set; }
        [Required]
        [DefaultValue(0)]
        public int Price { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public DateTime EstimatedDelivery { get; set; }

        public List<Order> Orders { get; set; }

}
}
