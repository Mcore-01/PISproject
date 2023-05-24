using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    public class PermissonAction
    {
        private User user;
        public PermissonAction(User user)
        {
            this.user = user;
        }

        public bool CanAddAnimal()
        {
            return user.role == "OperatorShelter";
        }
    }
}
