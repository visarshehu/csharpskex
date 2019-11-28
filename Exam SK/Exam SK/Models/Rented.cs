using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Rented

{       public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateOfRent { get; set; }
       
        public DateTime DateofReturn { get; set; }
        [Required]
        public int KilometersOnRent { get; set; }
       
        public int KilometersOnReturn { get; set; }
        public User User { get; set; }
        public Car car { get; set; }



    }
}
