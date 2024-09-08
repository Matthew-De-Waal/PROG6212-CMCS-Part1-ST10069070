using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult UserLogin()
        {
            return View();
        }

        public IActionResult UserRegistration()
        {
            return View();
        }

        public IActionResult UserAccount()
        {
            return View();
        }

        public IActionResult UpdateUserProfile()
        {
            return View();
        }
    }
}
