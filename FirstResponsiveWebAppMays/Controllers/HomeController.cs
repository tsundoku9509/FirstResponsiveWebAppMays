/**********************
 * Name: FirstResponsiveWebAppMays
 * Author: Austin Mays
 * Created: 06/05/2023
 * Course: CIS 174 - Advanced C#
 * Version: 1.0
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 * Input: User inputs their name and year of birth.
 * Output: The age they are that current day as well as the age they are come Dec. 31st, 2023.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstResponsiveWebAppMays.Models;

namespace FirstResponsiveWebAppMays.Controllers;

public class HomeController : Controller
{

    [HttpGet]

    public IActionResult Index()
    {
        ViewBag.Dec = 0;
        ViewBag.Current = 0;
        return View();
    }
    [HttpPost]
    public IActionResult Index(AgeThisYearModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Dec = model.AgeThisYear();
            ViewBag.Current = model.AgeToday();
        }
        else
        {
            ViewBag.Dec = 0;
            ViewBag.Current = 0;
        }
        return View(model);
    }

   
}
