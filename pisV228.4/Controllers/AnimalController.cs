using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisV228._4
{
    public class AnimalController : IController<Animal>
    {
        public User user;
        private PermissonAction PermissonAction;
        public AnimalController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }
        public void AddCard(Animal record)
        {
            // форма знает о контроллере, но обратно связи нет

            if (record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PermissonAction.CanAddAnimal())
            {
                MessageBox.Show("Вы не можете добавлять животных в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Добавлено", "Животное", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            DataBase.AddAnimal(record);

        }
        public List<Animal> GetCards()
        {
            return DataBase.GetAnimals();
        }

        public Animal GetCard(int animalID)
        {
            return DataBase.GetAnimalCard(animalID);
        }

        public void SaveAnimalRegister()
        {
            DataBase.WriteDataAnimals();
        }

        public void RemoveCard(int id)
        {
            DataBase.RemoveAnimalCard(id);
        }
    }
}
