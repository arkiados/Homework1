﻿using Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework1.Controllers
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
        public IActionResult SendForm(CardForm cardForm)
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