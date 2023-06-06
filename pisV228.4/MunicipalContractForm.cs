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
    public partial class MunicipalContractForm : Form
    {
        MunicipalContractController controller;
        MunicipalContract municipalContract;
        public MunicipalContractForm(MunicipalContractController controller)
        {
            InitializeComponent();
            this.controller = controller;
            ChangeGroupBox.Visible = false;
        }
        public MunicipalContractForm(MunicipalContractController controller, MunicipalContract municipalContract)
        {
            InitializeComponent();
            this.controller = controller;
            this.municipalContract = municipalContract;
            buttonMCFgroupbox.Visible = false;
        }

        private void MunicipalContractForm_Load(object sender, EventArgs e)
        {
            var municipalContractType = typeof(MunicipalContract);
            var propertys = municipalContractType.GetProperties();
            int y = 0;
            for (int i = 0; i < propertys.Length; i++)
            {

                var labelAtt = propertys[i].GetCustomAttributes(true).OfType<LabelAtt>().First();
                var label = new Label { Top = y, Left = 0, Width = this.ClientSize.Width / 2, Height = 16 };
                label.Text = labelAtt.LabelText;
                var textbox = new TextBox { Top = y, Left = label.Width, Width = (this.ClientSize.Width), Height = 16 };
                if (municipalContract != null)
                {
                    textbox.Text = propertys[i].GetValue(municipalContract).ToString();
                }
                textbox.Name = $"{propertys[i].Name}TB";
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                y += 16;
            }
            if (municipalContract != null)
            {
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = true;
                }
            }
            this.Controls.OfType<TextBox>().First().ReadOnly = true;
        }
        private void OpenChangeGroupBox(bool open)
        {
            foreach (var item in (this.Controls.OfType<TextBox>().Skip(1)))
                item.ReadOnly = !open;
            SaveButton.Visible = open;
            CancelChangeButton.Visible = open;
            ChangeButton.Visible = !open;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!controller.CanChangeCard())
                MessageBox.Show("Вы не можете изменять карточку!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else OpenChangeGroupBox(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
                data.Add(item.Text);
            controller.ChangeMunicipalContract(new MunicipalContract(data.ToArray()));
            OpenChangeGroupBox(false);
        }

        private void CancelChangeButton_Click(object sender, EventArgs e)
        {
            OpenChangeGroupBox(false);
        }
    }
}
