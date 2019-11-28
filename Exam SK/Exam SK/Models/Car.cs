using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Car
{
        [Required]
        [MinLength(2)]
        public string ManuFacturer { get; set; }

        public string Model { get; set; }

        public int YearOfProduction { get; set; }

        public string FuelType { get; set; }
        [Key]

        public string LicencePlate { get; set; }

        public DateTime DateRegistred { get; set; }

        public List<Rented> Rented;


    }
}
