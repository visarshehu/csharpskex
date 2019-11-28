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
            var item = from m in context.Orders
                       orderby m.DateOfOrder descending
                       select new
                       {
                           CyberTruck
                       };

            return View(item.Take(100));
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User m)
        {
            DatabaseContext c = new DatabaseContext();
            c.Users.Add(m);
            c.SaveChanges();
            return View();
        }
    }
}