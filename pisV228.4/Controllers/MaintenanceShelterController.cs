using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    public class MaintenanceShelterController
    {
        private User user;
        private PermissonAction PermissonAction;
        public MaintenanceShelterController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }
        public void AddMaintenanceShelterCard(MaintenanceShelter record, MaintenanceShelterForm formOpened)
        {
            if (!record.IsCorrect())
            {
                formOpened.Error("Данные были некорректны!", false);
            }
            if (!PermissonAction.CanAddMaintenanceShelter())
            {
                formOpened.Error("Вы не можете добавлять содержание в приюте в реестр!", false);
            }
            formOpened.Error("Добавлено", false);
            DataBase.AddMaintenanceShelter(record);

        }
        public List<MaintenanceShelter> GetMaintenanceShelterCards()
        {
            return DataBase.GetMaintenanceShelter();
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
