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
        
        public string Messages { get; set; }
        public DateTime DateSent { get; set; } = DateTime.Now;

        [DefaultValue(false)]
        public bool IsRead { get; set; }
        public List<ChatRoom> ChatRoomm { get; set; }
    }
}
