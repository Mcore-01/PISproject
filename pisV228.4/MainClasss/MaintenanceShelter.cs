using System;

namespace pisV228._4
{
    public class MaintenanceShelter : ICorrectable
    {
        [LabelAtt("Идентификатор содержание в приюте")]
        public int UniqueIdentifier { get; set; }

        [LabelAtt("Идентификатор животного")]
        public int CardAnimalWithoutOwners { get; set; }

        [LabelAtt("Результат проверки на агрессивность")]
        public string ResultAggressivenessCheck { get; set; }

        [LabelAtt("Дата проверки")]
        public DateTime DateCheck { get; set; }

        [LabelAtt("ФИО специалиста")]
        public string FullName { get; set; }

        [LabelAtt("Должность")]
        public string PositionSpecialist { get; set; }

        [LabelAtt("Приют")]
        public string Shelter { get; set; }

        [LabelAtt("Дата поступления")]
        public DateTime DateAdmission { get; set; }

        [LabelAtt("Дата отбытие")]
        public DateTime DateDeparture { get; set; }

        [LabelAtt("Номер вольера")]
        public int NumberEnclosure { get; set; }

        [LabelAtt("Идентификатор муниципального контракта")]
        public int MunicipalContract { get; set; }

        public MaintenanceShelter(object[] data)
        {
            UniqueIdentifier = Convert.ToInt32(data[0]);
            CardAnimalWithoutOwners = Convert.ToInt32(data[1]);
            ResultAggressivenessCheck = Convert.ToString(data[2]);
            DateCheck = Convert.ToDateTime(data[3]);
            FullName = Convert.ToString(data[4]);
            PositionSpecialist = Convert.ToString(data[5]);
            Shelter = Convert.ToString(data[6]);
            DateAdmission = Convert.ToDateTime(data[7]);
            DateDeparture = Convert.ToDateTime(data[8]);
            NumberEnclosure = Convert.ToInt32(data[9]);
            MunicipalContract = Convert.ToInt32(data[10]);
        }

        public bool IsCorrect()
        {
            return true;
        }
    }
}
