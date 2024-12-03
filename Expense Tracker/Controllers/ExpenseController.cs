using Microsoft.AspNetCore.Mvc;
using Expense_Tracker.Models;


namespace Expense_Tracker.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            Expense expense = new Expense();
            return View(expense); // Display list of expenses
        }

        public IActionResult Add()
        {
            return View(); // Form to add a new expense
        }

        public IActionResult Edit(int id)
        {
            return View(); // Edit an existing expense with a specific id
        }

        public IActionResult Delete(int id)
        {
            return View(); // Confirm deletion of an expense
        }
    }
}
