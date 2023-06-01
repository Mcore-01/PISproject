using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        public void AddOrganizationCard(Organization record)
        {
            if (record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PermissonAction.CanAddAnimal())
            {
                MessageBox.Show("Вы не можете добавлять организации в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Добавлено", "Организация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.AddOrganization(record);
        }
    }
}
