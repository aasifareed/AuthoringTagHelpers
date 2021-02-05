using AuthoringTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AuthoringTagHelpers.Controllers
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
            WebsiteContext websiteContext = new WebsiteContext();
            return View(websiteContext);
        }

        [HttpPost]
        public IActionResult Index(WebsiteContext websiteContext)
        {
            if(!ModelState.IsValid)
            return View();

            return null;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            // return View("AboutBoldOnly");
            return View();
        }

        public IActionResult Contact(int id = 0)
        {
            ViewData["Message"] = "Your contact page.";

            string view = "Contact";

            switch (id)
            {
                case 1:
                    view = "ContactCopy";
                    break;

                case 2:
                    view = "ContactVoid";
                    break;

                case 0:
                default:
                    view = "Contact";
                    break;
            }
            return View(view);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
