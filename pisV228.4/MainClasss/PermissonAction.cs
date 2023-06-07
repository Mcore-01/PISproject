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
        private HashSet<string> animalUsers = new HashSet<string>()
        {
            "Veterinarian",
            "OperatorShelter",
            "VeterinarianShelter"
        };

        private HashSet<string> organizationUsers = new HashSet<string>()
        {
            "OperatorVeterinaryServices",
            "OperatorOMSU"
        };

        private HashSet<string> contractUsers = new HashSet<string>()
        {
            "OperatorOMSU"
        };
        public PermissonAction(User user)
        {
            this.user = user;
        }

        public bool CanAddAnimal()
        {    
            return animalUsers.Contains(user.role);
        }

        public bool CanAddOrganization()
        {
            
            return organizationUsers.Contains(user.role);
        }

        public bool CanAddMunicipalContract()
        {
            return contractUsers.Contains(user.role);
        }

        public bool CanAddMaintenanceShelter()
        {
            return animalUsers.Contains(user.role);
        }

        public bool CanRemoveAnimal()
        {
            return animalUsers.Contains(user.role);
        }

        public bool CanRemoveOrganization()
        {

            return organizationUsers.Contains(user.role);
        }

        public bool CanRemoveMunicipalContract()
        {
            return contractUsers.Contains(user.role);
        }
    }
}
