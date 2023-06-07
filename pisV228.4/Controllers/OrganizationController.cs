using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
                throw new ArgumentException();
            }
            if (!PermissonAction.CanAddOrganization())
            {
                throw new InvalidOperationException();
            }


            DataBase.AddOrganization(record);
        }

        public void RemoveCard(Organization record)
        {
            if (!PermissonAction.CanRemoveOrganization())
            {
                throw new InvalidOperationException();
            }
            DataBase.RemoveOrganizationCard(record.OrganizationID);
        }

        public void SaveOrganizationRegister()
        {
            DataBase.WriteDataOrganization();
        }
    }
}
