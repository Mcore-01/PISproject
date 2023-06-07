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
    public partial class MunicipalContractRegisterForm : Form
    {
        private List<MunicipalContract> contracts;
        MunicipalContractController controller;
        public MunicipalContractRegisterForm(User user)
        {
            InitializeComponent();
            controller = new MunicipalContractController(user);
            MCRDataGridView.Columns.Add("columns1", "id");
            MCRDataGridView.Columns.Add("columns2", "номер");
            MCRDataGridView.Columns.Add("columns3", "Дата заключения");
            MCRDataGridView.Columns.Add("columns4", "Исполнитель");
            MCRDataGridView.Columns.Add("columns5", "Заказчик");
            MCRDataGridView.Columns[0].Width = 60;
            MCRDataGridView.Columns[1].Width = 100;
            MCRDataGridView.Columns[2].Width = 80;
            MCRDataGridView.Columns[3].Width = 80;
            MCRDataGridView.Columns[4].Width = 100;
            var columns = MCRDataGridView.Columns;
            for (int i = 1; i < columns.Count; i++)
            {
                ComboBoxSort.Items.Add(columns[i].HeaderText);//ToString());
            }

            UpdateRegister();
        }
        private void UpdateRegister(List<string> filters = null, int? sorting = null)
        {
            MCRDataGridView.Rows.Clear();
            contracts = controller.GetCards();
            foreach (var e in contracts)
            {
                MCRDataGridView.Rows.Add(e.MunicipalContractID, e.Number, e.DateConclusion, e.Customer, e.Contractor);
            }

            if (sorting != null)
            {
                var direction = ListSortDirection.Ascending;
                if (CheckBoxDesc.Checked)
                    direction = ListSortDirection.Descending;
                MCRDataGridView.Sort(MCRDataGridView.Columns[(int)sorting], direction);
            }
        }
        private void MunicipalContractRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenMCRButton_Click(object sender, EventArgs e)
        {
            if (MCRDataGridView.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(MCRDataGridView.CurrentRow.Cells[0].Value);
            var currentOrganization = contracts.First(x => x.MunicipalContractID == id);
            var formOrg = new MunicipalContractForm(controller, currentOrganization);
            if (formOrg.ShowDialog() == DialogResult.Yes)
            {
                UpdateRegister();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int? sorting = ComboBoxSort.SelectedIndex + 1;
            if (sorting == 0) sorting = null;
            UpdateRegister(null, sorting);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Execl files (*.xls)|*.xls";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string pathFile = saveFile.FileName;
            controller.Export(contracts, pathFile);
        }

        private void AddMCRButton_Click(object sender, EventArgs e)
        {
            var formOrg = new MunicipalContractForm(controller);
            if (formOrg.ShowDialog() == DialogResult.Yes)
            {
                UpdateRegister();
            }
        }

        private void RemoveMCRButton_Click(object sender, EventArgs e)
        {
            if (MCRDataGridView.CurrentRow == null)
            {
                return;
            }
            int id = Convert.ToInt32(MCRDataGridView.CurrentRow.Cells[0].Value);
            MCRDataGridView.CurrentRow.Visible = false;
            controller.RemoveCard(id);
        }
    }
}
