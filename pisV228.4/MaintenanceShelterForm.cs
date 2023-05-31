using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisV228._4
{
    public partial class MaintenanceShelterForm : Form
    {
        MaintenanceShelterController controller;
        List<MaintenanceShelter> maintenanceShelters;
        int currentPage;
        public MaintenanceShelterForm(MaintenanceShelterController controller)
        {
            InitializeComponent();
            this.controller = controller;
            PrevButtonMS.Visible = false;
            NextButtonMS.Visible = false;
        }
        public MaintenanceShelterForm(MaintenanceShelterController controller, List<MaintenanceShelter> list)
        {
            InitializeComponent();
            this.controller = controller;
            maintenanceShelters = list;
            currentPage = 0;
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
                if (maintenanceShelters != null && maintenanceShelters.Count != 0)
                {
                    textbox.Text = propertys[i].GetValue(maintenanceShelters[currentPage]).ToString();
                }
                //textbox.Text = propertys[i].GetValue(currentAnimal).ToString();
                textbox.Name = $"{propertys[i].Name}TB";
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                y += 16;
            }
            if (maintenanceShelters != null && maintenanceShelters.Count != 0)
            {
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = true;
                }
            }

        }

        

        private void AddMSFButton_Click(object sender, EventArgs e)
        {
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
            {
                data.Add(item.Text);
            }
            controller.AddMaintenanceShelterCard(new MaintenanceShelter(data.ToArray()), this);
        }

        private void CloseMSFButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Error(string message, bool close)
        {
            
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (close)
            {
                this.Close();
            }
        }

        private void NetxButtonMS_Click(object sender, EventArgs e)
        {
            if (currentPage <= maintenanceShelters.Count -1)
            {
                foreach (var item in (this.Controls.OfType<TextBox>()))
                {

                }
            }
        }
    }
}
