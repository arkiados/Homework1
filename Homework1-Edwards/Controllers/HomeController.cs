using Homework1_Edwards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework1_Edwards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult SendForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SentForm(CardForm cardForm)
        {
            if (ModelState.IsValid)
            {
                return View("SentForm", cardForm);
            }
            else
            {
                return View();
            }
        }
    }
}