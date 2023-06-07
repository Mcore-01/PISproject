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

        public void AddCard(MunicipalContract record)
        {
            if (record.IsCorrect())
            {
                throw new ArgumentException();
            }
            if (!PermissonAction.CanAddMunicipalContract())
            {
                throw new InvalidOperationException();
            }
            DataBase.AddMunicipalContract(record);
        }

        public void RemoveCard(int id)
        {
            DataBase.RemoveMunicipalContractCard(id);
        }

        public void SaveMunicipalContractRegister()
        {
            DataBase.WriteDataMunicipalContracts();
        }
    }
}
