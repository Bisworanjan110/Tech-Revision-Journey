using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models
{
    public interface IUserOperations
    {
        void AddUser(User user);
        void UpdateUser(string id,string name, string email);
        void DeleteUser(string id);
        List<User> GetAllUsers();
    }
}
