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

    public partial class MunicipalContractForm : Form
    {
        MunicipalContractController controller;
        //MunicipalContract municipalContract;
        
        public MunicipalContractForm(MunicipalContractController controller)
        {
            InitializeComponent();
            this.controller = controller;
            textBox1.Visible = false;
            label1.Visible = false;
        }
        public MunicipalContractForm(MunicipalContractController controller, MunicipalContract municipalContract)
        {
            InitializeComponent();
            this.controller = controller;
            //this.municipalContract = municipalContract;
            buttonMCFgroupbox.Visible = false;
            
            
            //dateTimePicker1.Enabled = false;
            var textBox4 = new TextBox() {Width = dateTimePicker1.Width,  Left = dateTimePicker1.Left, Top = dateTimePicker1.Top};
            var textBox5 = new TextBox() {Width = dateTimePicker2.Width,  Left = dateTimePicker2.Left, Top = dateTimePicker2.Top};
            var textBox6 = new TextBox() {Width = comboBox1.Width,  Left = comboBox1.Left, Top = comboBox1.Top};
            var textBox7 = new TextBox() {Width = comboBox2.Width,  Left = comboBox2.Left, Top = comboBox2.Top};     
            this.Controls.AddRange(new Control[] { textBox4, textBox5, textBox6, textBox7 });
 
            var type = typeof(MunicipalContract);
            var propertys = type.GetProperties();
            
            var textbox = this.Controls.OfType<TextBox>().ToArray();
            //MessageBox.Show(string.Join(" ", textbox.Select(x=>x.Name)), "das");
            for (int i = 0; i < propertys.Length; i++)
            {
                if (propertys[i].PropertyType == typeof(DateTime))
                {

                    textbox[i].Text = string.Format("{0:dd/MM/yyyy}", propertys[i].GetValue(municipalContract));
                }
                else
                {
                    textbox[i].Text = propertys[i].GetValue(municipalContract).ToString();
                }
                textbox[i].ReadOnly = true;
            }
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }

        private void MunicipalContractForm_Load(object sender, EventArgs e)
        {
            /*var municipalContractType = typeof(MunicipalContract);
            var propertys = municipalContractType.GetProperties();
            int y = 0;
            for (int i = 0; i < propertys.Length; i++)
            {

                var labelAtt = propertys[i].GetCustomAttributes(true).OfType<LabelAtt>().First();
                var label = new Label { Top = y, Left = 0, Width = this.ClientSize.Width / 2, Height = 16 };
                label.Text = labelAtt.LabelText;
                var textbox = new TextBox { Top = y, Left = label.Width, Width = (this.ClientSize.Width), Height = 16 };
                if (municipalContract != null)
                {
                    textbox.Text = propertys[i].GetValue(municipalContract).ToString();
                }
                textbox.Name = $"{propertys[i].Name}TB";
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                y += 16;
            }
            if (municipalContract != null)
            {
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.ReadOnly = true;
                }
            }
            this.Controls.OfType<TextBox>().First().ReadOnly = true;*/
            List<Organization> organizationList = new OrganizationController(controller.user).GetCards();
            List<Organization> organizationList2 = organizationList.ToList();
            comboBox1.DataSource = organizationList;
            comboBox2.DataSource = organizationList2;
            
            comboBox1.ValueMember = "Name";
            comboBox2.ValueMember = "Name";

            comboBox1.DisplayMember = "Name";
            comboBox2.DisplayMember = "Name";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void AddMCFButton_Click(object sender, EventArgs e)
        {
            var data = new List<object>();
            foreach (var item in (this.Controls.OfType<TextBox>()))
            {
                data.Add(item.Text);
            }

            data.Add(dateTimePicker1.Value);
            data.Add(dateTimePicker2.Value);
            data.Add(comboBox1.Text);
            data.Add(comboBox1.Text);
            data[0] = 1;
            try
            {
                controller.AddCard(new MunicipalContract(data.ToArray()));
                MessageBox.Show("Добавлен", "Контракт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Вы не можете добавлять контракты в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void CloseMCFButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
