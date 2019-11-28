using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class order
    {
        
        public string Name { get; set; }
        public string Surmane { get; set; }
        public string UName { get; set; }
        public string Password { get; set; }
        public DateTime DateOrder { get; set;}


        public string Email { get; set; }
        public int Id { get; set; }
        [Required]
        [MinLength(2)]

        public string Model { get; set; }
        public int Price { get; set; }
        [Required]
        [NotNull]

        public string Color { get; set; }
        [NotNull]
     
        public string EstimatedDelivery { get; set; }

        public double Value { get; private set; }
        public User User { get; private set; }

        public order(double value, User user)
        {
            this.Value = value;
            this.User = user;
        }
    }


} 

