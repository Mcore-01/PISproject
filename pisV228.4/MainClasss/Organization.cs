using System;

namespace pisV228._4
{
    public class Organization : ICorrectable
    {
        [LabelAtt("Индентификатор организация")]
        public int OrganizationID { get; set; }

        [LabelAtt("Наименование")]
        public string Name { get; set; }

        [LabelAtt("ИНН")]
        public string INN { get; set; }

        [LabelAtt("КПП")]
        public string KPP { get; set; }

        [LabelAtt("Адрес")]
        public string Address { get; set; }

        [LabelAtt("Тип организиция")]
        public string TypeOrganization { get; set; }

        [LabelAtt("ИП/Юридическое лицо")]
        public string TypeLegalEntity { get; set; }

        [LabelAtt("Населенный пункт")]
        public string Locality { get; set; }

        public Organization(object[] data)
        {
            try
            {
                OrganizationID = Convert.ToInt32(data[0]);
                Name = data[1].ToString();
                INN = data[2].ToString();
                KPP = data[3].ToString();
                Address = data[4].ToString();
                TypeOrganization = data[5].ToString();
                TypeLegalEntity = data[6].ToString();
                Locality = data[7].ToString();
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
