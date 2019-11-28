using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_SK.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam_SK.Controllers
{
    public class RentedController : Controller
    {
        public object LicencePlates { get; private set; }

        public IActionResult Action()
        {
            DatabaseContext r = new DatabaseContext();
            var a = (from r in a.Rented
                     orderby r.DateOfReturn descending
                     select r.DateOfRent).Take(LicencePlates);
        }



        public IActionResult AddCar(Car c)
        {
            DatabaseContext r = new DatabaseContext();
            r.Cars.Add(c);
            r.SaveChanges();
            return RedirectToAction("AddCar");
         }

       
    }
}