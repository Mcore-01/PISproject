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
        Animal animal;
        int currentPage;
        public MaintenanceShelterForm(MaintenanceShelterController controller, Animal animal)
        {
            InitializeComponent();
            this.controller = controller;
            PrevButtonMS.Visible = false;
            NextButtonMS.Visible = false;
            //comboBox1.Width = (this.ClientSize.Width);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.animal = animal;
        }
        public MaintenanceShelterForm(MaintenanceShelterController controller, List<MaintenanceShelter> list)
        {
            InitializeComponent();
            this.controller = controller;
            maintenanceShelters = list;
            currentPage = 0;
            AddMSFButton.Visible = false;
            CloseMSFButton.Visible = false;
            comboBox1.Visible = false;
        }
        private void MaintenanceShelter_Load(object sender, EventArgs e)
        {
            var animalType = typeof(MaintenanceShelter);
            var propertys = animalType.GetProperties();
            int y = 0;

            for (int i = 0; i < propertys.Length; i++)
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
            this.Controls.OfType<TextBox>().ToList()[0].Visible = false;
            this.Controls.OfType<TextBox>().ToList()[1].Visible = false;

            this.Controls.OfType<Label>().ToList()[0].Visible = false;
            this.Controls.OfType<Label>().ToList()[1].Visible = false;
            if (maintenanceShelters != null && maintenanceShelters.Count != 0)
            {
                this.Controls.OfType<Label>().ToList()[0].Visible = true;
                this.Controls.OfType<Label>().ToList()[1].Visible = true;
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.Visible = true;
                    textbox.ReadOnly = true;
                }
                //comboBox1.Visible = false;
               
            }
            /*else
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
            }*/
            /*this.Controls.OfType<TextBox>().ToList()[0].Visible = false;
            this.Controls.OfType<Label>().ToList()[0].Visible = false;

            this.Controls.OfType<TextBox>().ToList()[1].Visible = false;
            this.Controls.OfType<Label>().ToList()[1].Visible = false;*/

            List<MunicipalContract> organizationList = new MunicipalContractController(controller.user).GetCards();
            
            comboBox1.DataSource = organizationList;

            comboBox1.ValueMember = "MunicipalContractID";

            comboBox1.DisplayMember = "Number";
        }

        

        private void AddMSFButton_Click(object sender, EventArgs e)
        {
            var data = new List<object>();
            var textbox = this.Controls.OfType<TextBox>().ToList();
            for (int i = 0; i < textbox.Count()-1; i++)
            {
                data.Add(textbox[i].Text);
            }
            
            data.Add(comboBox1.ValueMember);
            //MessageBox.Show(String.Join(" ", textbox.Select(x => x.Text)) + comboBox1.ValueMember);
            controller.AddMaintenanceShelterCard(new MaintenanceShelter(data.ToArray(), animal));
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
            ChangePage(1);
        }

        private void ChangePage(int iterate)
        {
            var animalType = typeof(MaintenanceShelter);
            var propertys = animalType.GetProperties();
            if (currentPage + iterate >=0 && currentPage + iterate < maintenanceShelters.Count)
            {
                currentPage+=iterate;
                var currentCard = maintenanceShelters[currentPage];
                var textBoxs = (this.Controls.OfType<TextBox>());
                for (int i = 0; i < textBoxs.Count(); i++)
                {
                    textBoxs.ElementAt(i).Text = propertys[i].GetValue(currentCard).ToString();
                }
            }
        }

        private void PrevButtonMS_Click(object sender, EventArgs e)
        {
            ChangePage(-1);
        }

    }
}
