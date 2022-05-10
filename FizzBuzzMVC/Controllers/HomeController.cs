using FizzBuzzMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Controllers
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

        [HttpGet]
        public IActionResult FBPage()
        {
            FizzBuzz model = new();

            model.FizzValue = 3;
            model.BuzzValue = 5;

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]  // assure that the post is happening from within the application page
        // overloaded method
        public IActionResult FBPage(FizzBuzz fizzbuzz)
        {
            // evaluate the imput for FizzBuzz
            List<string> fbItems = new();

            bool isFizz;
            bool isBuzz;

            for (int i = 1; i <= 100; i++)
            {
                isFizz = (i % fizzbuzz.FizzValue == 0);
                isBuzz = (i % fizzbuzz.BuzzValue == 0);

                if (isFizz == true && isBuzz == true)
                {
                    fbItems.Add($"{i} - FizzBuzz");
                }
                else if (isFizz == true)
                {
                    fbItems.Add($"{i} - Fizz");
                }
                else if (isBuzz == true)
                {
                    fbItems.Add($"{i} - Buzz");
                }
                else
                {
                    fbItems.Add(i.ToString());
                }
            }
            
            
            fizzbuzz.Results = fbItems;

            return View(fizzbuzz);
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
    }
}
