using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace game.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Simulation()
        {
            return View();
        }

        public IActionResult Shooting()
        {
            return View();
        }

        public IActionResult Sport()
        {
            return View();
        }

        public IActionResult Rpg()
        {
            return View();
        }
    }
}
