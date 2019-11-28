using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
   
        public class ChatRoom
        {
            
            public string Name { get; set; }
            public DateTime DateCreated { get; set; }

            public User Users { get; set; }
            public Message Messages { get; set; }
        }
 }

