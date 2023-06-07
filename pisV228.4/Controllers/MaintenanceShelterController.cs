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
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PermissonAction.CanAddMaintenanceShelter())
            {
                MessageBox.Show("Вы не можете добавлять карточку содержания животного в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Добавлен", "Контракт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataBase.AddMaintenanceShelter(record);

        }
        public List<MaintenanceShelter> GetMaintenanceShelterCards(Animal animal)
        {
            return DataBase.GetMaintenanceShelter(animal);
        }
/*
        public Animal GetAnimalCard(int animalID)
        {
            return DataBase.GetAnimalCard(animalID);
        }

        public void SaveAnimalRegister()
        {
            DataBase.WriteDataAnimals();
        }*/
    }
}
