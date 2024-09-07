using CMCS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMCS.Controllers
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

        public IActionResult UserLogin()
        {
            return View();
        }

        public IActionResult UserRegistration()
        {
            return View();
        }

        public IActionResult Status()
        {
            return View();
        }

        public IActionResult UserAccount()
        {
            return View();
        }

        public IActionResult NewRequest()
        {
            return View();
        }

        public IActionResult TrackRequest()
        {
            return View();
        }

        public IActionResult ManageRequests()
        {
            return View();
        }

        public IActionResult CancelRequest()
        {
            return View();
        }

        public IActionResult CancelRequestSuccess()
        {
            return View();
        }

        public IActionResult UpdateUserProfile()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUs()
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
    }
}
