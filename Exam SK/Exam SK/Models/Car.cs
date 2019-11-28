using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Car
{        [MinLength(2)]
         [Required]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime YearOfProduction { get; set; }
        public string FuelType { get; set; }
        [Key]
        public string LicencePlate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DataRegistered { get; set; }
        public List<Rented>Renteds { get; set; }
        
    }
}
