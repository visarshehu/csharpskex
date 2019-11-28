using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam_SK.Models;
namespace Exam_SK.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext c = new DatabaseContext();
            var item =from m in c.Messages
                       select m.MessageText;

            return View(item.ToList());
        }

        public IActionResult Action()
        {
            DatabaseContext c = new DatabaseContext();
            var a =(from m in c.Messages
                    orderby m.DateSent descending
                    select m.MessageText).Take(10);
                        
            return View(a);
        }

        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(Message m)
        {
            DatabaseContext c = new DatabaseContext();
            c.Messages.Add(m);
            c.SaveChanges();
            return RedirectToAction ("Index");
            
        }
    }
}