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
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();
            var item = from c in context.Renteds
                       orderby c.DateOfRent
                       select c;
            return View(item.ToList());
        }
        public IActionResult AddCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCar(Car c)
        {
            DatabaseContext context = new DatabaseContext();
            context.Cars.Add(c);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}