using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Order
{
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateOfOrder { get; set; }
        public int Bid { get; set; }

        
        
        public CyberTruck CyberTrucks { get; set; }

        
        
        public User Users { get; set; }
}
}
