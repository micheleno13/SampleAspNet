using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleAspNet.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World!");
        }

        public IActionResult Show()
        {
            ViewData["Message"] = "Welcome to the Hello Controller!";
            return View();
        }        
    }
}