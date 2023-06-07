using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace pisV228._4
{
    public class MunicipalContractController : IController<MunicipalContract>
    {
        public User user;
        private PermissonAction PermissonAction;
        public MunicipalContractController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }
        public List<MunicipalContract> GetCards()
        {
            return DataBase.GetMunicipalContracts();
        }

        public MunicipalContract GetCard(int id)
        {
            return DataBase.GetMunicipalContractCard(id);
        }
        public bool CanChangeCard()
        {
            return PermissonAction.CanChangeCard();
        }

        public void AddCard(MunicipalContract record)
        {
            if (record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PermissonAction.CanAddAnimal())
            {
                MessageBox.Show("Вы не можете добавлять контракты в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Добавлен", "Контракт", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.AddMunicipalContract(record);
        }
        public void ChangeMunicipalContract(MunicipalContract record)
        {
            if (!record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Карточка изменена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.ChangeMunicipalContract(record);
        }

        internal void Export(List<MunicipalContract> contracts, string pathFile)
        {
            if (!PermissonAction.CanExport())
            {
                MessageBox.Show("Вы не можете экспортировать карточки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application excel = new Excel.Application();
            excel.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)excel.ActiveSheet;

            var contarctType = typeof(MunicipalContract);
            var propertys = contarctType.GetProperties();
            for (int i = 0; i < contracts.Count; i++)
            {
                for (int j = 0; j < propertys.Length; j++)
                    wsh.Cells[i + 2, j + 1] = propertys[j].GetValue(contracts[i]);
            }

            for (int j = 0; j < propertys.Length; j++)
            {
                wsh.Cells[1, j + 1] = propertys[j].Name;
                wsh.Columns[j + 1].AutoFit();
            }
            excel.Visible = true;
            wsh.SaveAs(pathFile);
        }
    }
}
