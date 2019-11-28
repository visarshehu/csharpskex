using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_SK.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Exam_SK.Controllers
{
    public class orderController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext c = new DatabaseContext();
            var a = from o in o.order orderby o.DateSent descending
                    select o.order;
            return View();
        }
        public IActionResult Adduser(user )
        {
            return View();
        }
        [Http Post]
        public IActionResult Adduser(user u)        
        
            DatabaseContext c = new DatabaseContext();
       c.order Add(u);
        c.order add private changes(u);

   
    }
    }
}