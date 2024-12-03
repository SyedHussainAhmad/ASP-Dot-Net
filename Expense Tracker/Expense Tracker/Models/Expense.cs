using System;

namespace Expense_Tracker.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string URL { get; set; }
    }
}
