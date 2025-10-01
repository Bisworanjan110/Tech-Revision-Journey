using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models
{
    public sealed class Admin : User
    {
        public string Privileges {  get; set; }
    }
}
