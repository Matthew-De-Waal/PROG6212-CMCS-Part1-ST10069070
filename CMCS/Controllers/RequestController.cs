using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult Status()
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
    }
}
