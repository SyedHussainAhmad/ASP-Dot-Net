namespace Expense_Tracker.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "User"; // Default role is User, can be expanded to Admin, etc.
        public ICollection<Expense> Transactions { get; set; }
    }
}
