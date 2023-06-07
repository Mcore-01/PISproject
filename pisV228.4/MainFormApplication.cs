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
    public partial class MainFormApplication : Form
    {
        private User user;
        public MainFormApplication(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AnimalButton_Click(object sender, EventArgs e)
        {
            var form = new AnimalRegisterForm(user);
            form.Show();
        }

        private void OrganizationButton_Click(object sender, EventArgs e)
        {
            var form = new OrganizationRegisterForm(user);
            form.Show();
        }

        private void ContractButton_Click(object sender, EventArgs e)
        {
            var form = new MunicipalContractRegisterForm(user);
            form.Show();
        }
    }
}
