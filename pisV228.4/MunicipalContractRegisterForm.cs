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
            UpdateRegister();
        }
        private void UpdateRegister()
        {
            contracts = controller.GetCards();
            foreach (var e in contracts)
            {
                MCRDataGridView.Rows.Add(e.MunicipalContractID, e.Number, e.DateConclusion, e.Customer, e.Contractor);
            }
        }
        private void MunicipalContractRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
