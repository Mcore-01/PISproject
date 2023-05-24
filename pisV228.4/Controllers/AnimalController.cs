using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    public class AnimalController
    {
        private User user;
        private PermissonAction PermissonAction;
        public AnimalController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }
        public void AddAnimalCard(Animal record, AnimalForm formOpened)
        {
            if (!record.IsCorrect())
            {
                formOpened.Error("Данные были некорректны!", false);
            }
            if (!PermissonAction.CanAddAnimal())
            {
                formOpened.Error("Вы не можете добавлять животных в реестр!", false);
            }
            formOpened.Error("Добавлено", false);
            DataBase.AddAnimal(record);

        }
        public List<Animal> GetAnimalCards()
        {
            return DataBase.GetAnimals();
        }

        public Animal GetAnimalCard(int animalID)
        {
            return DataBase.GetAnimalCard(animalID);
        }

        public void SaveAnimalRegister()
        {
            DataBase.WriteDataAnimals();
        }
    }
}
