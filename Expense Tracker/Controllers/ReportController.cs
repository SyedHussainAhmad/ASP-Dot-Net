using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Display the list of available reports
        }

        public IActionResult GenerateReport()
        {
            return View(); // Generate a specific report (e.g., monthly, yearly)
        }
    }
}
