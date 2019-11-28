using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Exam_SK.Models
{
    public class Car
    {
        [MinLength(2)]
        [Required]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime YearOfProduction { get; set; }
        public string FuelType { get; set; }
        [Key]
        public string LicencePlate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateRegistered { get; set; }

        List<Rented> Rented { get; set; }

    }
}
