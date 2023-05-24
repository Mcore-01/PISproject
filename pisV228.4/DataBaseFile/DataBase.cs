using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pisV228._4
{
    public class DataBase
    {
        private static int animalID;
        private static List<Animal> animals = ReadDataAnimals(); /*= new List<Animal>()
        {
            new Animal(new object[]{1, "Матмассы", "Собака", "М", "01.01.2012", 1234, "Боня", "Черно-белая", "Ошейник", @"C:\Users\mk19\source\repos\pisV228.4\pisV228.4\PictureAnimal\QPBaStuDUlw.jpg"})
        };*/
        public static List<MaintenanceShelter>  MainShelter = new List<MaintenanceShelter>();

        public static List<Organization> organizations = new List<Organization>();

        public static List<MunicipalContract> municipalContracts = new List<MunicipalContract>();

        public static void AddAnimal(Animal data)
        {
            animalID++;
            data.AnimalID = animalID;
            animals.Add(data);
        }

        public static List<Animal> GetAnimals()
        {
            return new List<Animal>();
        }

        public static Animal GetAnimalCard(int id)
        {
            return animals.First(x => x.AnimalID == id);
        }

        private static List<object[]> ReadTxt(string path)
        {
            var text = File.ReadAllLines(path);
            var array = text.Select(x => x.Split(',') as object[]).ToList();
            return array;
        }
        private static List<Animal> ReadDataAnimals()
        {
            var readedData = ReadTxt(@"C:\Users\mk19\source\repos\pisV228.4\pisV228.4\DataBaseFile\DataAnimals.txt")
                .Select(x=> new Animal(x)).ToList();
            animalID = readedData.Max(x=>x.AnimalID);
            return readedData;
        }
        public static void WriteDataAnimals()
        {
            var type = typeof(Animal);
            var property = type.GetProperties();
            List<string> data = new List<string>();
            foreach (var e in animals)
            {
                List<object> temp = new List<object>();
                
                foreach (var item in property)
                {
                    temp.Add(item.GetValue(e));
                }
                data.Add(string.Join(",", temp));
            }
            File.WriteAllLines(@"C:\Users\mk19\source\repos\pisV228.4\pisV228.4\DataBaseFile\DataAnimals.txt", data);
        }
    }
}
