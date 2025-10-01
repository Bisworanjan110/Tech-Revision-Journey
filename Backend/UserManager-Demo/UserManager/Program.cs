using UserManager.Models;
using UserManager.Services;

namespace UserManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManagerSys manager = new UserManagerSys();

            User user1 = new User
            {
                Id = UserHelper.GenerateUserId(),
                Name = "Alice Brown",
                Email = "alice@example.com",
                Role = "Admin"
            };
            manager.AddUser(user1);

            User user2 = new User
            {
                Id = UserHelper.GenerateUserId(),
                Name = "Bob Smith",
                Email = "bob@example.com",
                Role = "User"
            };
            manager.AddUser(user2);

            User user3 = new User
            {
                Id = UserHelper.GenerateUserId(),
                Name = "Charlie Roy",
                Email = "charlie@example.com",
                Role = "User"
            };
            manager.AddUser(user3);

            User user4 = new Admin
            {
                Id = UserHelper.GenerateUserId(),
                Name = "Diana Patel",
                Email = "diana@example.com",
                Role = "Admin",
                Privileges = "Manage Users, Access Billing"
            };
            manager.AddUser(user4);

            // Update a user
            Console.WriteLine("\n--- Updating Charlie's Email ---");
            manager.UpdateUser("U103", "Charlie Roy", "charlie.new@example.com");

            // Delete a user
            Console.WriteLine("\n--- Deleting Bob ---");
            manager.DeleteUser("U102");

            // Search by Name
            Console.WriteLine("\n--- Searching for 'Alice' ---");
            var searchResults = manager.SearchByName("Alice");
            foreach (var user in searchResults)
            {
                user.DisplayDetails();
            }

            // Group by Role
            manager.GroupByRole();

            Console.WriteLine("\n All operations completed.");
        }
    }
}
