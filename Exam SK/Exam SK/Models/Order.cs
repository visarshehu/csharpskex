using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class Order
    {
        public int Id { get; set; }
        //[DataType(DataType.Date)]
        //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateofOrder { get; set; }
        public int Bid { get; set; }


        public  User User { get; set; }
        public string Username { get; set; }
        
        public CyberTruck cyberTruck { get; set; }
        public int CyberId { get; set; }


    }
}
