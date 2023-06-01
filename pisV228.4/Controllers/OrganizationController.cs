using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    public class OrganizationController
    {
        public User user;
        private PermissonAction PermissonAction;
        public OrganizationController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }

        public List<Organization> GetOrganizationCards()
        {
            return DataBase.GetOrganizations();
        }

        public Organization GetOrganizationCard(int OrganizationID)
        {
            return DataBase.GetOrganizationCard(OrganizationID);
        }
    }
}
