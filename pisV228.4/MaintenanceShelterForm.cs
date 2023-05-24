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
    public partial class MaintenanceShelterForm : Form
    {
        MaintenanceShelterController controller;
        public MaintenanceShelterForm(MaintenanceShelterController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void MaintenanceShelter_Load(object sender, EventArgs e)
        {
            var animalType = typeof(MaintenanceShelter);
            var propertys = animalType.GetProperties();
            int y = 0;

            for (int i = 0; i < propertys.Length - 1; i++)
            {
                var labelAtt = propertys[i].GetCustomAttributes(true).OfType<LabelAtt>().First();
                var label = new Label { Top = y, Left = 0, Width = this.ClientSize.Width / 2, Height = 16 };
                label.Text = labelAtt.LabelText;
                //label.Text = propertys[i].Name;
                var textbox = new TextBox { Top = y, Left = label.Width, Width = (this.ClientSize.Width), Height = 16 };
                //textbox.Text = propertys[i].GetValue(currentAnimal).ToString();
                textbox.Name = $"{propertys[i].Name}TB";
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                y += 16;
            }
            
        }

        

        private void AddMSFButton_Click(object sender, EventArgs e)
        {
            //StringBuilder str = new StringBuilder();
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
            {
                //str.Append(item.Text);
                data.Add(item.Text);
            }
            
            //MessageBox.Show(str.ToString());
            controller.AddMaintenanceShelterCard(new MaintenanceShelter(data.ToArray()), this);
        }

        private void CloseMSFButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Error(string message, bool close)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
