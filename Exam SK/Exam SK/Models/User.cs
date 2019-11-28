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
    public string Uname { get; set; }
    [Required]
    [MinLength(8)]
    public string Password { get; set; }
    public string Email { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedDate { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime UpdatedDate { get; set; }

    public List<Order> Orders { get; set; }
}
}
