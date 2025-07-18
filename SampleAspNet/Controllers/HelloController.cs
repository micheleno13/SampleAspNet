using System;
using Microsoft.AspNetCore.Mvc;
using SampleAspNet.Models;

namespace SampleAspNet.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _db;

        public HelloController(MyContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return Content("Hello, World!");
        }

        public IActionResult Show()
        {
            ViewData["Message"] = "Welcome to the Hello Controller!";
            return View();
        }

        public IActionResult List()
        {
            var books = _db.Books.ToList();
            return View(books);
        }
    }
}