using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(); // List all categories
        }

        public IActionResult Add()
        {
            return View(); // Form to add a new category
        }

        public IActionResult Edit(int id)
        {
            return View(); // Edit an existing category
        }

        public IActionResult Delete(int id)
        {
            return View(); // Confirm deletion of a category
        }
    }
}
