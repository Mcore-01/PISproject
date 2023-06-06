using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pisV228._4.Controllers;

namespace pisV228._4
{
    public partial class Statistic : Form
    {
        private List<Object> stat;
        public Statistic()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewTextBoxColumn Column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column5 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.AddRange(new DataGridViewColumn[]{ Column1, Column2, Column3, Column4, Column5 });
            Column1.HeaderText = "Общее кол-во животных";
            Column2.HeaderText = "Пиковое кол-во животных";
            Column3.HeaderText = "Общее кол-во дней содержания";
            Column4.HeaderText = "Среднее кол-во дней содержания";
            Column5.HeaderText = "Стоимость содержания по городу";
        }

        private void MakeStatistic()
        {
            var dateStart = start.Value;
            var datEnd = end.Value;
            var location_ = location.Text;
            ReportController repControl = new ReportController(dateStart, datEnd, location_);
            stat = repControl.statistic;
        }

        private void OkBut_Click(object sender, EventArgs e)
        {
            MakeStatistic();
        }
    }
}
