using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pisV228._4;
using pisV228._4.MainClasss;

namespace pisV228._4.Controllers
{
    public class ReportController
    {
        private DateTime dateStart;
        private DateTime dateEnd;
        private string location;
        private List<MunicipalContract> contracts;
        private List<MaintenanceShelter> maintenanceShelterList;
        public List<object> statistic;
        public ReportController(DateTime dateStart, DateTime dateEnd, string location)
        {
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.location = location;
            contracts = DataBase.GetMunicipalContract();
            if (contracts.Count != 0)
            {
                maintenanceShelterList = DataBase.GetMaintenanceShelter();
            }

            else
            {
                throw new Exception("Контракты отсутствуют!");
            }

            Create();
        }

        private void Create()
        {
            pisV228._4.MainClasss.Action action = new pisV228._4.MainClasss.Action(dateStart, dateEnd, location, contracts, maintenanceShelterList);
            statistic = action.GetStatistic();
        }
    }
}
