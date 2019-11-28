using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_SK.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam_SK.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();

            var orderss = from c in context.cyberTrucks
                          orderby c.EstimatedDelivery descending
                          select c;

            var table = orderss.Take(100);


            return View(table.ToList());
        }
       

        public IActionResult AddUser()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User u)
        {
            DatabaseContext context = new DatabaseContext();
            context.Users.Add(u);
            context.SaveChanges();

            return View();
        }


    }
}