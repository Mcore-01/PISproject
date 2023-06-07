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

        internal void Export(int? sorting, string filters, string pathFile)
        {
            if (!PermissonAction.CanExport())
            {
                MessageBox.Show("Вы не можете экспортировать карточки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var organizations = this.GetSortedCards(filters, sorting);
            var fullOrganization = new List<Organization>();
            foreach (var e in organizations)
            {
                fullOrganization.Add(this.GetCard(e.OrganizationID));
            }
            ReportMaker.MakeReportOrganzation(fullOrganization, pathFile);
        }
        
        public void RemoveCard(int id)
        {
            DataBase.RemoveOrganizationCard(id);
        }

        public List<Organization> GetSortedCards(string filters = null, int? sorting = null)
        {
            var listOrg = new List<Organization>();
            var organizations = this.GetCards();
            foreach (var e in organizations)
            {
                var org = new Organization(new object[] { 0 });
                org.OrganizationID = e.OrganizationID;
                org.Name = e.Name;
                org.INN = e.INN;
                org.KPP = e.KPP;
                org.Locality = e.Locality;

                if (filters != null)
                {
                    if (e.OrganizationID.ToString() == filters || e.Name == filters ||
                        e.INN == filters || e.KPP == filters || e.Locality == filters)
                    {

                        listOrg.Add(org);
                    }
                }
                else listOrg.Add(org);
            }

            if (sorting != null)
            {
                if (sorting == 1)
                    listOrg = listOrg.OrderBy(x => x.Name).ToList();
                else if (sorting == 2)
                    listOrg = listOrg.OrderBy(x => x.INN).ToList();
                else if (sorting == 3)
                    listOrg = listOrg.OrderBy(x => x.KPP).ToList();
                else if (sorting == 4)
                    listOrg = listOrg.OrderBy(x => x.Locality).ToList();
            }

            return listOrg;
        }
    }
}
