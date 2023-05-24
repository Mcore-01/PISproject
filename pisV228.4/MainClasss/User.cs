using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public User(string login, string password, string role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }
    }
}
