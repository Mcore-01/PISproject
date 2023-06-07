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
            if (!PermissonAction.CanAddMunicipalContract())
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

            ReportMaker.MakeReportContracts(contracts, pathFile);
        }

        public void RemoveCard(int id)
        {
            DataBase.RemoveMunicipalContractCard(id);
        }

        public List<MunicipalContract> GetSortedCards(string filters = null, int? sorting = null, bool toDesc = false)
        {
            var listContr = new List<MunicipalContract>();
            var contracts = this.GetCards();
            foreach (var e in contracts)
            {
                var contr = new MunicipalContract(new object[] { 0 });
                contr.MunicipalContractID = e.MunicipalContractID;
                contr.Number = e.Number;
                contr.DateConclusion = e.DateConclusion;
                contr.Customer = e.Customer;
                contr.Contractor = e.Contractor;

                if (filters != null)
                {
                    if (e.MunicipalContractID.ToString() == filters || e.Number.ToString() == filters ||
                        e.DateConclusion.ToString() == filters || e.Customer == filters || e.Contractor == filters)
                    {
                        
                        listContr.Add(contr);
                    }
                }
                else listContr.Add(contr);
            }

            if (sorting != null)
            {
                var type = typeof(MunicipalContract);
                var props = type.GetProperties();
                listContr.Sort();
                //if (toDesc)

/*                if (CheckBoxDesc.Checked)
                    MCRDataGridView.Sort(MCRDataGridView.Columns[(int)sorting], direction);*/
            }

            return listContr;
        }
    }
}
