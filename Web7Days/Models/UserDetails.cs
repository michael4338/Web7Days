using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web7Days.Models
{
    public class UserDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsValidUser(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}