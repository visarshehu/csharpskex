using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Exam_SK.Models
{
    public class Rented
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateOfRent { get; set; }
        public DateTime? DateOfReturn { get; set; }
        [Required]
        public int KilometersOnRent { get; set; }
        public int? KilometresOnReturn { get; set; }

        [Key]
        public int CarID { get; set; }

        public User Users { get; set; }
        public Car Cars { get; set; }
    }
}
