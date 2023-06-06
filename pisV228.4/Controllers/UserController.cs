using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4.Controllers
{
    public class UserController
    {
        private string login;
        private string password;
        public UserController(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public User GetUser(string login, string password)
        {
            DataBase data = new DataBase();
            var user = GetUser(login, password);
            return user;
        }
    }
}
