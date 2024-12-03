using Microsoft.AspNetCore.Mvc;
using Pizza_Delivery_App.Models;
using System.Diagnostics;

namespace Pizza_Delivery_App.Controllers
{
    public class UserController : Controller
    {
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
