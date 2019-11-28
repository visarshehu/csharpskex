using System;
using System.ComponentModel.DataAnnotations;

namespace Exam_SK.Models
{
    public class CyberTruck
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]

        public string Model { get; set; }
        public int Price { get; set; }
        [Required]

        //Console.WriteLine(default(int));  

      
        public string Color { get; set; }
        [NotNull]
        public string EstimatedDelivery { get; set; }
      


    }
}