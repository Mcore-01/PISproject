using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace pisV228._4
{
    public class OrganizationController : IController<Organization>
    {
        public User user;
        private PermissonAction PermissonAction;
        public OrganizationController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }

        public List<Organization> GetCards()
        {
            return DataBase.GetOrganizations();
        }

        public Organization GetCard(int OrganizationID)
        {
            return DataBase.GetOrganizationCard(OrganizationID);
        }

        public void AddCard(Organization record)
        {
            if (record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PermissonAction.CanAddOrganization())
            {
                MessageBox.Show("Вы не можете добавлять организации в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Добавлена", "Организация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.AddOrganization(record);
        }

        internal bool CanChangeCard()
        {
            return PermissonAction.CanChangeCard();
        }

        internal void ChangeOrganization(Organization record)
        {
            if (!record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Карточка изменена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.ChangeOrganization(record);
        }

        internal void Export(List<Organization> organizations, string pathFile)
        {
            if (!PermissonAction.CanExport())
            {
                MessageBox.Show("Вы не можете экспортировать карточки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReportMaker.MakeReportOrganzation(organizations, pathFile);
        }
        
        public void RemoveCard(int id)
        {
            DataBase.RemoveOrganizationCard(id);
        }
    }
}
