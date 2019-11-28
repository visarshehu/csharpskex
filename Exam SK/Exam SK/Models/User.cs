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
        [MaxLength(20)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [Key]
        public string UName { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Email { get; set; }
        //[DataType(DataType.Date)]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        //[DataType(DataType.Date)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedDate { get; set; }

        public List<Order> orders { get; set; }
    }
}
