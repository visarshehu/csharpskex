using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Rented
{
        public DateTime DateOfRent { get; set; } = DateTime.Now;

        public DateTime DateOfReturn { get; set; } = DateTime.Now;
        [Required]
        public int KilometersOnRent { get; set; }

        public int KilometersOnReturn { get; set; }

        public User Users;

        public Car Cars;
    }
}
