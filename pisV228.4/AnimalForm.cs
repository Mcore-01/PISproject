using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pisV228._4
{
    public partial class AnimalForm : Form
    {
        //private bool IsAddition;
        private AnimalController controller;
        private MaintenanceShelterController controllerMS;
        private string pathPicture;
        private Animal currentAnimal;
        public AnimalForm(AnimalController controller)
        {
            InitializeComponent();
            this.controller = controller;
            controllerMS = new MaintenanceShelterController(controller.user);
            MainShelterGroupBox.Visible = false;
        }
        public AnimalForm(AnimalController controller, Animal currentAnimal)
        {
            InitializeComponent();
            this.controller = controller;
            this.currentAnimal = currentAnimal;
            
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            var animalType = typeof(Animal);
            var propertys = animalType.GetProperties();
            int y = 0;
            for (int i = 0; i < propertys.Length-1; i++)
            {
                
                var labelAtt = propertys[i].GetCustomAttributes(true).OfType<LabelAtt>().First();
                var label = new Label { Top = y, Left = 0, Width = this.ClientSize.Width / 2, Height = 16 };
                label.Text = labelAtt.LabelText;
                var textbox = new TextBox { Top = y, Left = label.Width, Width = (this.ClientSize.Width), Height = 16 };
                if (currentAnimal != null)
                {
                    textbox.Text = propertys[i].GetValue(currentAnimal).ToString();
                }
                textbox.Name = $"{propertys[i].Name}TB";
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                y += 16;
            }
            AFPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (currentAnimal != null && currentAnimal.Photo != "")
            {
                LoadImageButton.Visible = false;
               // AFPictureBox.Image = Image.FromFile(currentAnimal.Photo);
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = true;
                }
            }
            this.Controls.OfType<TextBox>().First().Text = "1";
            this.Controls.OfType<TextBox>().First().Visible = false;
            this.Controls.OfType<Label>().First().Visible = false;
        }

        private void AddAFButton_Click(object sender, EventArgs e)
        {
            //StringBuilder str = new StringBuilder();
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
            {
                //str.Append(item.Text);
                data.Add(item.Text);
            }
            string newPath = "";
            if (pathPicture != null && pathPicture != "")
            {
                var newNameFile = Path.GetFileName(pathPicture);
                newPath = @"C:\Users\mk19\source\repos\pisV228.4\pisV228.4\PictureAnimal\" + newNameFile;
                try
                {
                    File.Copy(pathPicture, newPath);
                }
                catch (Exception)
                {
                    newPath += "1";
                    File.Copy(pathPicture, newPath);
                }
            }
            data.Add(newPath);
            //MessageBox.Show(str.ToString());
            controller.AddAnimalCard(new Animal(data.ToArray()), this);
        }






        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            var path = GetPathImage();
            if (path is null)
            {
                return;
            }
            ShowImage(path);
            LoadImageButton.Visible = false;
        }

        private string GetPathImage()
        {
            var imageDialog = new OpenFileDialog();
            imageDialog.ShowDialog();
            var pathImage = imageDialog.FileName;
            return pathImage;
            //ShowImage(pathImage);
        }
        private void ShowImage(string path)
        {
            pathPicture = path;
            if (path == "")
            {
                return;
            }
            AFPictureBox.Image = Image.FromFile(path);
        }

        private void AFPictureBox_Click(object sender, EventArgs e)
        {
            var path = GetPathImage();
            if (path is null)
            {
                return;
            }
            ShowImage(path);
        }


        public void Error(string message, bool closeForm)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (closeForm)
            {
                this.Close();
            }
        }

        private void CloseAFButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenMainShelterButton_Click(object sender, EventArgs e)
        {
    
        }

        private void AddMainShelterButton_Click(object sender, EventArgs e)
        {
            var formMS = new MaintenanceShelterForm(controllerMS);
            formMS.Show();
        }
    }
}
