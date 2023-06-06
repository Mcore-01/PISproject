using pisV228._4.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisV228._4
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            Send();
        }

        public void Send()
        {
            string login_ = login.Text;
            string password_ = password.Text;
            UserController userControl = new UserController(login_, password_);
        }
    }
}
