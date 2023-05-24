using System;


namespace pisV228._4
{
    public class MunicipalContract : ICorrectable
    {
        [LabelAtt("Идентификатор муниципального контракта")]
        public int MunicipalContractID { get; set; }

        [LabelAtt("Номер")]
        public int Number { get; set; }

        [LabelAtt("Стоимость одного дня содержания")]
        public decimal CostDayMaintenance { get; set; }

        [LabelAtt("Дата заключения")]
        public DateTime DateConclusion { get; set; }

        [LabelAtt("Дата действия")]
        public DateTime DateAction { get; set; }

        [LabelAtt("Исполнитель")]
        public string Contractor { get; set; }

        [LabelAtt("Заказчик")]
        public string Customer { get; set; }

        public bool IsCorrect()
        {
            return true;
        }
    }
}
