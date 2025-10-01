using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models
{
    public class User:UserBase
    {
        public string Role { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} | Email: {Email} | Role: {Role}");
        }
    }
}
