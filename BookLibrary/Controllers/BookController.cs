using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            Book model = new Book();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Book model)
        {
            return RedirectToAction("Confirmation", model);
        }

        public IActionResult Confirmation(Book model)
        {
            return View(model);
        }
    }
}
