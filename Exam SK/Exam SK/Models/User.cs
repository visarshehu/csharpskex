using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class User
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [Key]
        public string UName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }
        public bool HasDriverLicence { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedDate { get; set; }

        List<Rented> Rented { get; set; }
    }
}
