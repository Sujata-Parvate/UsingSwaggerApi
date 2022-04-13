using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostData()
        {
            string str = "";
            foreach (string key in Request.Form.Keys)
            {
                str = str + "\\n" + key + "=" + Request.Form[key];

            }
            //--------  Save this data to our database

            ViewBag.str = str;

             Response.Redirect("http://localhost:4200/");


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
    }
}
