using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Messages { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateSent { get; set; } = DateTime.Now;


        [DefaultValue(false)]
        public bool IsRead { get; set; }

        public List<ChatRoom> chatRooms { get; set; }


    }
}
