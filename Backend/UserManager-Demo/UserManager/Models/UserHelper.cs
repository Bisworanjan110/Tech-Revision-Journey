using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models
{
    public static class UserHelper
    {
        static int userId = 100;
        public static string GenerateUserId()
        {
            string newUserId = "U"+userId.ToString();
            userId = userId + 1;
            return newUserId;
        }
    }
}
