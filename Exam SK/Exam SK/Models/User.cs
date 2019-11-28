using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class User
{
        public int  Id { get; set; }

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
        [MaxLength(10)]
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; } = DateTime.Now;

        public List<ChatRoom> ChatRoomm { get; set; }
    }
}
