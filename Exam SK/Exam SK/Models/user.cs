using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace    Exam_SK.Models
{
    public class user
    {
        [required]
        [MaxLength(20)]
        [MinLength(5)]

        public string Name { get; set; }
        [required]
        public string Surmane { get; set; }
        [required]
        public string UName { get; set; }
        [required]
        [key]
        public string Password { get; set; }
        [required]

        public string Emil { get; set; }
        public DateTime Createdate { get; set; } = DateTime.Now;
        public DateTime Uptatedate { get; set; } = DateTime.Now;
         public List<CyberTruck>CyberTruck{get;set;}
      
    }
}
