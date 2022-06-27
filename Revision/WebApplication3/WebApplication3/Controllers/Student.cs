using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "lokesh";
            ViewBag.Dept = "dotnet";
            return View();
           

        }
    }
}
