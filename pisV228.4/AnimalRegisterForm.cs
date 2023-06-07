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
    public partial class AnimalRegisterForm : Form
    {
        private List<Animal> animals;
        private AnimalController controller;
        public AnimalRegisterForm(User user)
        {
            InitializeComponent();
            controller = new AnimalController(user);
            ARDataGridView.Columns.Add("columns1", "id");
            ARDataGridView.Columns.Add("columns2", "категория");
            ARDataGridView.Columns.Add("columns3", "пол");
            ARDataGridView.Columns.Add("columns4", "кличка");
            ARDataGridView.Columns.Add("columns5", "населенный пункт");
            ARDataGridView.Columns[0].Width = 60;
            ARDataGridView.Columns[1].Width = 80;
            ARDataGridView.Columns[2].Width = 80;
            ARDataGridView.Columns[3].Width = 80;
            ARDataGridView.Columns[4].Width = 80;
            UpdateRegister();
        }

        private void UpdateRegister()
        {
            ARDataGridView.Rows.Clear();
            animals = controller.GetCards();
            foreach (var e in animals)
            {
                ARDataGridView.Rows.Add(e.AnimalID, e.Category, e.Gender, e.NameAnimal, e.Locality);
            }
        }

        private void AddARButton_Click(object sender, EventArgs e)
        {
            var form = new AnimalForm(controller);
            if (form.ShowDialog() == DialogResult.Yes)
            {
                UpdateRegister();
            }
        }

        private void AnimalRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenARButton_Click(object sender, EventArgs e)
        {
            if (ARDataGridView.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(ARDataGridView.CurrentRow.Cells[0].Value);
            var currentAnimal = animals.First(x => x.AnimalID == id);
            var form = new AnimalForm(controller, currentAnimal);
            form.Show();
        }

        private void AnimalRegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.SaveAnimalRegister();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Execl files (*.xls)|*.xls";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string pathFile = saveFile.FileName;
            controller.Export(animals, pathFile);
            
        private void RemoveARButton_Click(object sender, EventArgs e)
        {
            if (ARDataGridView.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(ARDataGridView.CurrentRow.Cells[0].Value);
            ARDataGridView.CurrentRow.Visible = false;
            controller.RemoveCard(id);
        }
    }
}
