using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class User
{
        [Required]
        [MaxLength(15)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]

        public string Surname { get; set; }
        [Required]
        [Key]

        public string UName { get; set; }

        [Required]

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime Birthdaydate { get; set; }

        public string HasDriverLicence { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public List<Rented> Rented;



    }
}
