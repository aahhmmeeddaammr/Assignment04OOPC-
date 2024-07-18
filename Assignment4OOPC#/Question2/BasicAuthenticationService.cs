using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOPC_.Question2
{
    enum Role
    {
        User, 
        Admin
    }
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public Role Role { get; set; }
        public BasicAuthenticationService()
        {
            UserName = "AhmedAmr";
            Password = "12345678";
            Role = Role.Admin;
        }
        public bool AuthenticateUser(string username , string password)
        {
            if (   username is not null 
                && password is not null 
                && UserName is not null
                && Password is not null 
                && username == UserName 
                && password == Password  )
            {
                   return true;
            }
            return false;

        }

        public bool AuthorizeUser(string _Role)
        {
            if (_Role ==null  )
            {
                return false;
            }
            if(Role == (Role)Enum.Parse(typeof(Role), _Role, true) ) {
                return true;
            }
            return false;
        }

    }
}
