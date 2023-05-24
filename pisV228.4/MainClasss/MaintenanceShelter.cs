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

        public bool IsCorrect()
        {
            return true;
        }
    }
}
