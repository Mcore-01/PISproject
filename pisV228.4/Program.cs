﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisV228._4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            User user = new User("login", "password", "OperatorShelter");
            User user2 = new User("login", "password", "OperatorOMSU");
            Application.Run(new MainFormApplication(user));
            //Application.Run(new OrganizationRegisterForm(user2));
            //Application.Run(new MunicipalContractRegisterForm(user2));
        }
    }
}
