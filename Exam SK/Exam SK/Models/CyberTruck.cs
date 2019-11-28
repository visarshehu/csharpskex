using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class CyberTruck 
    {
        public int Id { get; set; }
        [MinLength(2)]
        [Required]
        public string Model { get; set; }
        [Required]
        [System.ComponentModel.DefaultValue("$0")]
        public decimal Price { get; set; } = 0;

        [Required]
        public string Color { get; set; }
        [Required]
        public DateTime EstimatedDelivery { get; set; }

        public List<Order> order { get; set; }
    }
}
