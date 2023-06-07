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
    public partial class OrganizationRegisterForm : Form
    {
        private List<Organization> organizations;
        OrganizationController controller;
        public OrganizationRegisterForm(User user)
        {
            InitializeComponent();
            controller = new OrganizationController(user);
            ORDataGridView.Columns.Add("columns1", "id");
            ORDataGridView.Columns.Add("columns2", "наименование");
            ORDataGridView.Columns.Add("columns3", "ИНН");
            ORDataGridView.Columns.Add("columns4", "КПП");
            ORDataGridView.Columns.Add("columns5", "населенный пункт");
            ORDataGridView.Columns[0].Width = 60;
            ORDataGridView.Columns[1].Width = 100;
            ORDataGridView.Columns[2].Width = 80;
            ORDataGridView.Columns[3].Width = 80;
            ORDataGridView.Columns[4].Width = 100;

            var columns = ORDataGridView.Columns;
            for (int i = 1; i < columns.Count; i++)
            {
                ComboBoxSort.Items.Add(columns[i].HeaderText);//ToString());
            }
            UpdateRegister();
        }
        private void UpdateRegister(List<string> filters = null, int? sorting = null)
        {
            ORDataGridView.Rows.Clear();
            organizations = controller.GetCards();
            foreach (var e in organizations)
            {
                ORDataGridView.Rows.Add(e.OrganizationID, e.Name, e.INN, e.KPP, e.Locality);
            }

            if (sorting != null)
            {
                var direction = ListSortDirection.Ascending;
                if (CheckBoxDesc.Checked)
                    direction = ListSortDirection.Descending;
                ORDataGridView.Sort(ORDataGridView.Columns[(int)sorting], direction);
            }
        }
        private void OrganizationRegisterForm_Load(object sender, EventArgs e)
        {
            /*var animalType = typeof(Organization);
            var propertys = animalType.GetProperties();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < propertys.Length; i++)
            {
                var labelAtt = propertys[i].GetCustomAttributes(true).OfType<LabelAtt>().First();
                str.Append(labelAtt.LabelText + ", ");
                
            }
            textBox1.Text = str.ToString();*/
        }

        private void AddORButton_Click(object sender, EventArgs e)
        {
            var formOrg = new OrganizationForm(controller);
            if (formOrg.ShowDialog() == DialogResult.Yes)
            {
                UpdateRegister();
            }
        }

        private void OpenORButton_Click(object sender, EventArgs e)
        {
            if (ORDataGridView.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(ORDataGridView.CurrentRow.Cells[0].Value);
            var currentOrganization = organizations.First(x => x.OrganizationID == id);
            var formOrg = new OrganizationForm(controller, currentOrganization);
            if (formOrg.ShowDialog() == DialogResult.Yes)
            {
                UpdateRegister();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Execl files (*.xls)|*.xls";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string pathFile = saveFile.FileName;
            controller.Export(organizations, pathFile);
        }    

        private void RemoveORButton_Click(object sender, EventArgs e)
        {
            if (ORDataGridView.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(ORDataGridView.CurrentRow.Cells[0].Value);
            ORDataGridView.CurrentRow.Visible = false;
            controller.RemoveCard(id);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int? sorting = ComboBoxSort.SelectedIndex + 1;
            if (sorting == 0) sorting = null;
            UpdateRegister(null, sorting);
        }
    }
}
