using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filter;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Helo(String name, string loc,string contact)
        {
            ViewBag.Username = name;
            ViewBag.Location = loc;
            ViewBag.Contact = contact;
            return View();
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



        public string CSRetest()
        {
            return "csharp test is today @5pm; get prepared";
        }
        [ResponseCache(Duration = 10)]
        [Mylog]

        public string Retest()
        {
            return DateTime.Now.ToString();
        }
        [Mylog]
        public string retests()

        {
            return "c#=12-sep";

        }
    }
}