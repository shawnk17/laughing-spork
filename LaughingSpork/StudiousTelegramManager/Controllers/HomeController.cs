using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudiousTelegramManager.Models;
using ApplicationCore.Entities;

namespace StudiousTelegramManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Telegram newGram = new Telegram
            //{
            //    Id = 1,
            //    Sender = "Jeff",
            //    Receiver = "Shawn",
            //    Title = "Hi Shawn",
            //    Content = "Look! My town has a telegraph now!!"
            //};

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
