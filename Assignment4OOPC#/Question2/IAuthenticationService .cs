using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOPC_.Question2
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string username , string password);

        public bool AuthorizeUser(string role);

    }
}
