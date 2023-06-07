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
    public partial class OrganizationForm : Form
    {
        private OrganizationController controller;
        private Organization organization;
        public OrganizationForm(OrganizationController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        public OrganizationForm(OrganizationController controller, Organization card)
        {
            InitializeComponent();
            this.controller = controller;
            buttonOFgroupbox.Visible = false;
            organization = card;
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {
            var organizationType = typeof(Organization);
            var propertys = organizationType.GetProperties();
            int y = 0;
            for (int i = 0; i < propertys.Length; i++)
            {

                var labelAtt = propertys[i].GetCustomAttributes(true).OfType<LabelAtt>().First();
                var label = new Label { Top = y, Left = 0, Width = this.ClientSize.Width / 2, Height = 16 };
                label.Text = labelAtt.LabelText;
                var textbox = new TextBox { Top = y, Left = label.Width, Width = (this.ClientSize.Width), Height = 16 };
                if (organization != null)
                {
                    textbox.Text = propertys[i].GetValue(organization).ToString();
                }
                textbox.Name = $"{propertys[i].Name}TB";
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                y += 16;
            }
            if (organization != null)
            {
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = true;
                }
            }
            this.Controls.OfType<TextBox>().First().ReadOnly = true;
        }

        private void AddOFButton_Click(object sender, EventArgs e)
        {
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
            {
                //str.Append(item.Text);
                data.Add(item.Text);
            }
            data[0] = 1;
            controller.AddCard(new Organization(data.ToArray()));
        }
        private void OpenChangeGroupBox(bool open)
        {
            foreach (var item in (this.Controls.OfType<TextBox>().Skip(1)))
                item.ReadOnly = !open;
            SaveButton.Visible = open;
            CancelChangeButton.Visible = open;
            ChangeButton.Visible = !open;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
                data.Add(item.Text);
            controller.ChangeOrganization(new Organization(data.ToArray()));
            OpenChangeGroupBox(false);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!controller.CanChangeCard())
                MessageBox.Show("Вы не можете изменять карточку!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else OpenChangeGroupBox(true);
        }

        private void CancelChangeButton_Click(object sender, EventArgs e)
        {
            OpenChangeGroupBox(false);
        }
    }
}
