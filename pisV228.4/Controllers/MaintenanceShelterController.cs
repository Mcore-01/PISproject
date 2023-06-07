using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisV228._4
{
    public class MaintenanceShelterController
    {
        public User user;
        private PermissonAction PermissonAction;
        public MaintenanceShelterController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }
        public void AddMaintenanceShelterCard(MaintenanceShelter record)
        {
            if (!record.IsCorrect())
            {
                throw new ArgumentException();
            }
            if (!PermissonAction.CanAddMaintenanceShelter())
            {
                throw new InvalidOperationException();
            }
            DataBase.AddMaintenanceShelter(record);

        }
        public List<MaintenanceShelter> GetMaintenanceShelterCards(Animal animal)
        {
            return DataBase.GetMaintenanceShelter(animal);
        }

        /*public void SaveAnimalRegister()
        {
            DataBase.WriteDataAnimals();
        }*/
    }
}
