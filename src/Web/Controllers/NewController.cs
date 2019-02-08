using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Text()
        {
            return Content("Some text");
        }
        public IActionResult Json()
        {
            return Json(new {
                name = "New JSON data",
                type = "JSON data"
            });
        }
        public IActionResult Html()
        {
            return Content("<!DOCTYPE html><html><body><button> new buuton</button></body></html>", "text/html");
        }
    }
}