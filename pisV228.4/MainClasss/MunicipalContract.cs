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

        public MunicipalContract(object[] data)
        {
            MunicipalContractID = Convert.ToInt32(data[0]);
            Number = Convert.ToInt32(data[1]);
            CostDayMaintenance = Convert.ToInt32(data[2]);
            DateConclusion = Convert.ToDateTime(data[3]);
            DateAction = Convert.ToDateTime(data[4]);
            Contractor = data[5].ToString();
            Customer = data[6].ToString();
        }
        public bool IsCorrect()
        {
            return true;
        }
    }
}
