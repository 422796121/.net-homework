﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace game.Controllers
{
    public class MygameController : Controller
    {
        public IActionResult Mygame()
        {
            return View();
        }

    }
}
