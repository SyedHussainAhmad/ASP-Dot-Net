using Microsoft.AspNetCore.Mvc;
using Pizza_Delivery_App.Models;
using System.Diagnostics;

namespace Pizza_Delivery_App.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        [Route("Menu")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
