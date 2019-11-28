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
        [MinLength(5)]
        [MaxLength(20)]
        public string Name{ get; set; }
        [Required]
        public string Surname{ get; set; }
        [Required]
        [Key]
        public string UName { get; set; }
        [Required]
        [MinLength(10)]
        public string  Password { get; set; }
        public string  Email { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public List<ChatRoom> chatRooms { get; set; }


    }
}
