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
        public List<Animal> GetAnimalCards()
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

        internal void Export(List<Animal> animals, string pathFile)
        {
            if (!PermissonAction.CanExport())
            {
                MessageBox.Show("Вы не можете экспортировать карточки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application excel = new Excel.Application();
            excel.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)excel.ActiveSheet;

            var animalType = typeof(Animal);
            var propertys = animalType.GetProperties();
            for (int i = 0; i < animals.Count; i++)
            {
                for (int j = 0; j < propertys.Length; j++)
                    wsh.Cells[i + 2, j + 1] = propertys[j].GetValue(animals[i]);
            }

            for (int j = 0; j < propertys.Length; j++)
            {
                wsh.Cells[1, j + 1] = propertys[j].Name;
                wsh.Columns[j + 1].AutoFit();
            }
            excel.Visible = true;
            wsh.SaveAs(pathFile);
            
        public void RemoveCard(int id)
        {
            DataBase.RemoveAnimalCard(id);
        }
    }
}
