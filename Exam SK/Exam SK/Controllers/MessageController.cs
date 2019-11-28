using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_SK.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam_SK.Controllers
{
    public class MessageController : Controller
    {
       
        public IActionResult Index()
        {
            DatabaseContext c = new DatabaseContext();

            var a = (from m in c.Message
                     orderby m.DateSent descending
                     select m.Messages).Take(10);

            return View(a.ToList());
        }
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(Message m)
        {
            DatabaseContext c = new DatabaseContext();

            c.Message.Add(m);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}