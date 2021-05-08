using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEmpty.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }
        public ActionResult SayHello()
        {
            return Content("Welcome to My site");
        }
    }
}
