using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models
{
    public abstract class UserBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public abstract void DisplayDetails();
    }
}
