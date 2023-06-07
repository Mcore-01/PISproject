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
    public partial class SearchForm : Form
    {
        public int SortIndex = 0;
        public SearchForm(DataGridViewColumnCollection columns)
        {
            InitializeComponent();
            for (int i = 1; i < columns.Count; i++)
            {
                ComboBoxSort.Items.Add(columns[i].HeaderText);//ToString());
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var SortIndex = ComboBoxSort.SelectedIndex;
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
