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
        public MaintenanceShelterForm()
        {
            InitializeComponent();
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
    }
}
