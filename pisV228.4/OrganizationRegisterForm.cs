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
        private void UpdateRegister(string filters = null, int? sorting = null)
        {
            ORDataGridView.Rows.Clear();
            organizations = controller.GetSortedCards(filters, sorting);
            foreach (var organization in organizations)
            {
                ORDataGridView.Rows.Add(organization.OrganizationID, organization.Name, organization.INN, organization.KPP, organization.Locality);
            }
        }
        private void OrganizationRegisterForm_Load(object sender, EventArgs e)
        {
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

            int? sorting = ComboBoxSort.SelectedIndex + 1;
            if (sorting == 0) sorting = null;
            string filters = textBox1.Text;
            if (filters == "") filters = null;

            controller.Export(sorting, filters, pathFile);
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
            string filters = textBox1.Text;
            if (filters == "") filters = null;
            UpdateRegister(filters, sorting);
        }
    }
}
