using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace pisV228._4
{
    [TestFixture]
    class MakeStatistics_Shoulde
    {
        [SetUp]
        public void SetUp()
        {
            DataBase.number = 234;
            DataBase.costDayMaintenance = 13000;
            DataBase.dateConclusion = new DateTime(13/04/2013);
            DataBase.dateAction = new DateTime(13/04/2016);
            DataBase.contractor = "ООО Радуга";
            DataBase.customer = "ООО Заказчик";
            MunicipalContract municipal = new MunicipalContract();
            DataBase.AddMunicipalContract(municipal);
        }

        public void Test()
        {

        }
    }
}
