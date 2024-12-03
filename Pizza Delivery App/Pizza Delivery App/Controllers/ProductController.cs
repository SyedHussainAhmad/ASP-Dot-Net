using Microsoft.AspNetCore.Mvc;
using Pizza_Delivery_App.Models;
using System.Diagnostics;

namespace Pizza_Delivery_App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Cart")]
        public IActionResult Cart()
        {
            return View();
        }
    }
}
