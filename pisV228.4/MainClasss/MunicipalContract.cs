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
            try
            {
                MunicipalContractID = Convert.ToInt32(data[0]);
                Number = Convert.ToInt32(data[1]);
                CostDayMaintenance = Convert.ToDecimal(data[2]);
                DateConclusion = Convert.ToDateTime(data[3]);
                DateAction = Convert.ToDateTime(data[4]);
                Contractor = Convert.ToString(data[5]);
                Customer = Convert.ToString(data[6]);
            }
            catch
            {
                IsCorrectCard = false;
            }
        }

        public bool IsCorrect()
        {
            return IsCorrectCard;
        }
  
        private bool IsCorrectCard = true;
    }
}
