using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisV228._4
{
    public class MunicipalContractController : IController<MunicipalContract>
    {
        public User user;
        private PermissonAction PermissonAction;
        public MunicipalContractController(User user)
        {
            this.user = user;
            PermissonAction = new PermissonAction(user);
        }
        public List<MunicipalContract> GetCards()
        {
            return DataBase.GetMunicipalContracts();
        }

        public MunicipalContract GetCard(int id)
        {
            return DataBase.GetMunicipalContractCard(id);
        }
        public bool CanChangeCard()
        {
            return PermissonAction.CanChangeCard();
        }

        public void AddCard(MunicipalContract record)
        {
            if (record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PermissonAction.CanAddAnimal())
            {
                MessageBox.Show("Вы не можете добавлять контракты в реестр!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Добавлен", "Контракт", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.AddMunicipalContract(record);
        }
        public void ChangeMunicipalContract(MunicipalContract record)
        {
            if (!record.IsCorrect())
            {
                MessageBox.Show("Данные были некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Карточка изменена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataBase.ChangeMunicipalContract(record);
        }
    }
}
