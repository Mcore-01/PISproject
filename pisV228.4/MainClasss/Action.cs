using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4.MainClasss
{
    class Action
    {
        private List<MunicipalContract> contracts;
        private List<MaintenanceShelter> maintenanceShelterList;
        private DateTime dateStart;
        private DateTime dateEnd;
        private string location;
        private int countOfAnimals;
        private int diff;
        private int countOfDays;
        private decimal cost;
        private List<Object> statistics;
        public Action(DateTime dateStart, DateTime dateEnd, string location, List<MunicipalContract> contracts, List<MaintenanceShelter> maintenanceShelterList)
        {
            this.contracts = contracts;
            this.maintenanceShelterList = maintenanceShelterList;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.location = location;
        }

        private int CalculateCountOfAnimal()
        {
            var count = 0;
            List<int> animals = new List<int>();
            for(int i = 0; i < maintenanceShelterList.Count; i++)
            {
                if ((maintenanceShelterList[i].DateAdmission >= dateStart) && (maintenanceShelterList[i].DateDeparture <= dateEnd) && (maintenanceShelterList[i].City == location))
                {
                    animals.Add(maintenanceShelterList[i].CardAnimalWithoutOwners);
                }
            }
            foreach (var item in animals)
            {
                count++;
            }

            return count;
        }

        private int CalculateMaxCountOfAnimal()
        {
            List<int> animals = new List<int>();
            for (int i = 0; i < maintenanceShelterList.Count; i++)
            {
                if (maintenanceShelterList[i].City == location)
                {
                    animals.Add(maintenanceShelterList[i].CardAnimalWithoutOwners);
                }
            }
            foreach (var item in animals)
            {
                countOfAnimals++;
            }

            return countOfAnimals;
        }

        private int CalculateCountOfDays()
        {
            for (int i = 0; i < maintenanceShelterList.Count; i++)
            {
                if ((maintenanceShelterList[i].DateAdmission >= dateStart) && (maintenanceShelterList[i].DateDeparture <= dateEnd) && (maintenanceShelterList[i].City == location))
                {
                    diff = maintenanceShelterList[i].DateAdmission.Day - maintenanceShelterList[i].DateDeparture.Day;
                    countOfDays = 0;
                    countOfDays += diff;
                }
            }

            return countOfDays;
        }

        private int CalculateMiddleCountOfDays()
        {
            for (int i = 0; i < maintenanceShelterList.Count; i++)
            {
                if ((maintenanceShelterList[i].DateAdmission >= dateStart) && (maintenanceShelterList[i].DateDeparture <= dateEnd) && (maintenanceShelterList[i].City == location))
                {
                    diff = maintenanceShelterList[i].DateAdmission.Day - maintenanceShelterList[i].DateDeparture.Day;
                    countOfDays = 0;
                    countOfDays += diff;
                }
            }

            return countOfDays / 2;
        }

        private decimal CalculateOfCost()
        {
            for (int i = 0; i < contracts.Count; i++)
            {
                if ((maintenanceShelterList[i].DateAdmission >= dateStart) && (maintenanceShelterList[i].DateDeparture <= dateEnd) && (maintenanceShelterList[i].City == location) && (maintenanceShelterList[i].MunicipalContract == contracts[i].MunicipalContractID))
                {
                    cost = 0;
                    cost += contracts[i].CostDayMaintenance * countOfDays;
                }
            }

            return cost;
        }

        public List<Object> GetStatistic()
        {
            statistics.Add(CalculateCountOfAnimal());
            statistics.Add(CalculateMaxCountOfAnimal());
            statistics.Add(CalculateCountOfDays());
            statistics.Add(CalculateMiddleCountOfDays());
            statistics.Add(CalculateOfCost());
            return statistics;
        }
    }
}
