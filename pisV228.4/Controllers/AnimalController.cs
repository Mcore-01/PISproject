using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
        
        public bool CanChangeCard()
        {
            return PermissonAction.CanChangeCard();
        }
        public void ChangeAnimalCard(Animal record)
        {
            if (record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Карточка изменена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.ChangeAnimal(record);
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

        internal void Export(int? sorting, string filters, string pathFile)
        {
            if (!PermissonAction.CanExport())
            {
                MessageBox.Show("Вы не можете экспортировать карточки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var animals = GetSortedCards(filters, sorting);
            ReportMaker.MakeReportAnimals(animals, pathFile);
        }
        
        public void RemoveCard(int id)
        {
            DataBase.RemoveAnimalCard(id);
        }

        public List<Animal> GetSortedCards(string filters = null, int? sorting = null)
        {
            var listAnimals = new List<Animal>();
            var contracts = this.GetCards();
            foreach (var e in contracts)
            {
                var animal = new Animal(new object[] { 0 });
                //e.AnimalID, e.Category, e.Gender, e.NameAnimal, e.Locality
                animal.AnimalID = e.AnimalID;
                animal.Category = e.Category;
                animal.Gender = e.Gender;
                animal.NameAnimal = e.NameAnimal;
                animal.Locality = e.Locality;

                if (filters != null)
                {
                    if (e.AnimalID.ToString() == filters || e.Category == filters ||
                        e.Gender == filters || e.NameAnimal == filters || e.Locality == filters)
                    {

                        listAnimals.Add(animal);
                    }
                }
                else listAnimals.Add(animal);
            }

            if (sorting != null)
            {
                if (sorting == 1)
                    listAnimals = listAnimals.OrderBy(x => x.Category).ToList();
                else if (sorting == 2)
                    listAnimals = listAnimals.OrderBy(x => x.Gender).ToList();
                else if (sorting == 3)
                    listAnimals = listAnimals.OrderBy(x => x.NameAnimal).ToList();
                else if (sorting == 4)
                    listAnimals = listAnimals.OrderBy(x => x.Locality).ToList();
            }

            return listAnimals;
        }
    }
}
