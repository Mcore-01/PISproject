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

        [LabelAtt("Населенный пункт")]
        public string TypeLegalEntity { get; set; }

        [LabelAtt("Населенный пункт")]
        public string Locality { get; set; }

        public bool IsCorrect()
        {
            return true;
        }
    }
}
