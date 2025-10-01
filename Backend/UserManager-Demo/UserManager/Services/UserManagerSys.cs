using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Models;

namespace UserManager.Services
{
    public class UserManagerSys:IUserOperations
    {
        List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void UpdateUser(string id, string name, string email)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.Name = name;
                user.Email = email;

                Console.WriteLine($"User with {id} updated successfully!");
            }
            else
            {
                Console.WriteLine($"User not found.");
            }
        }
        public void DeleteUser(string id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if(user != null)
            {
                users.Remove(user);
                Console.WriteLine("User removed successfully!");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        public List<User> GetAllUsers()
        {
            return users;
        }
        public List<User> SearchByName(string name)
        {
            var usersWithName = users.Where(u=>u.Name == name || u.Name.Contains(name)).ToList();
            return usersWithName;
        }
        public void GroupByRole()
        {
            var groupedUsers = users.GroupBy(u => u.Role).ToList();
            Console.WriteLine("\n📊 Users Grouped by Role:");

            foreach (var group in groupedUsers)
            {
                Console.WriteLine($"\nRole: {group.Key} | Count: {group.Count()}");
                foreach (var user in group)
                {
                    Console.WriteLine($"- {user.Name} (ID: {user.Id}, Email: {user.Email})");
                }
            }
        }
    }
}
