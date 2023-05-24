using System;

namespace pisV228._4
{
    
    public class Animal : ICorrectable
    {
        [LabelAtt("Индентификатор животного")]
        public int AnimalID { get; set; }

        [LabelAtt("Населенный пункт")]
        public string Locality { get; set; }

        [LabelAtt("Категория")]
        public string Category { get; set; }

        [LabelAtt("Пол")]
        public string Gender { get; set; }

        [LabelAtt("Год рождения")]
        public DateTime YearBirth { get; set; }

        [LabelAtt("Номер чипа")]
        public int ChipNumber { get; set; }

        [LabelAtt("Кличка")]
        public string NameAnimal { get; set; }
        
        [LabelAtt("Приметы")]
        public string SpecialSings { get; set; }

        [LabelAtt("Признаки наличия хозяина")]
        public string PresenceSingsOwner { get; set; }

        [LabelAtt("Фотография")]
        public string Photo { get; set; }
        public Animal(object[] data)
        {
            AnimalID = Convert.ToInt32(data[0]);
            Locality = Convert.ToString(data[1]);
            Category = Convert.ToString(data[2]);
            Gender = Convert.ToString(data[3]);
            YearBirth = Convert.ToDateTime(data[4]);
            ChipNumber = Convert.ToInt32(data[5]);
            NameAnimal = Convert.ToString(data[6]);
            SpecialSings = Convert.ToString(data[7]);
            PresenceSingsOwner = Convert.ToString(data[8]);
            Photo = Convert.ToString(data[9]);
        }
        public bool IsCorrect()
        {
            return true;
        }
    }
}
