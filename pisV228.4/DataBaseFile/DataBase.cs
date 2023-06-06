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
        private static int msID;
        private static int mcID;
        private static int orgID;
        private static List<Animal> animals = ReadDataAnimals(); /*= new List<Animal>()
        {
            new Animal(new object[]{1, "Матмассы", "Собака", "М", "01.01.2012", 1234, "Боня", "Черно-белая", "Ошейник", @"C:\Users\mk19\source\repos\pisV228.4\pisV228.4\PictureAnimal\QPBaStuDUlw.jpg"})
        };*/
        public static List<MaintenanceShelter> mainShelters = ReadDataMS();//= new List<MaintenanceShelter>();

        private static List<Organization> organizations = ReadDataOrganization();

        public static List<MunicipalContract> municipalContracts = ReadDataMContract();

        public static void AddAnimal(Animal data)
        {
            animalID++;
            data.AnimalID = animalID;
            animals.Add(data);
        }
        
        public static void AddOrganization(Organization data)
        {
            orgID++;
            data.OrganizationID = orgID;
            organizations.Add(data);
        }
        public static void AddMunicipalContract(MunicipalContract data)
        {
            mcID++;
            data.MunicipalContractID = mcID;
            municipalContracts.Add(data);
        }
        public static List<Animal> GetAnimals()
        {
            return animals;
        }
        
        public static List<Organization> GetOrganizations()
        {
            return organizations;
        }
        public static List<MunicipalContract> GetMunicipalContracts()
        {
            return municipalContracts;
        }
        public static List<MaintenanceShelter> GetMaintenanceShelter(Animal animal)
        {
            return mainShelters.Where(x => x.CardAnimalWithoutOwners == animal.AnimalID).ToList();
        }
        
        public static Animal GetAnimalCard(int id)
        {
            return animals.First(x => x.AnimalID == id);
        }
        public static Organization GetOrganizationCard(int id)
        {
            return organizations.First(x => x.OrganizationID == id);
        }

        public static MunicipalContract GetMunicipalContractCard(int id)
        {
            return municipalContracts.First(x => x.MunicipalContractID == id);
        }
        private static List<object[]> ReadTxt(string path)
        {
            var text = File.ReadAllLines(path);
            var array = text.Where(line => line.Length != 0).Select(x => x.Split(',') as object[]).ToList();
            return array;
        }
        private static List<Animal> ReadDataAnimals()
        {
            var path = Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "DataBaseFile\\DataAnimals.txt");
            var readedData = ReadTxt(path)
                .Select(x=> new Animal(x)).ToList();
            animalID = readedData.Max(x=>x.AnimalID);
            return readedData;
        }
       

        public static void WriteDataAnimals()
        {
            var path = Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "DataBaseFile\\DataAnimals.txt");
            WriteData(path, animals);
            //File.WriteAllLines(, data);
        }

        private static List<MaintenanceShelter> ReadDataMS()
        {
            var path = Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "DataBaseFile\\DataMainShelters.txt");

            var readedData = ReadTxt(path)
                .Select(x => new MaintenanceShelter(x)).ToList();
            msID = readedData.Max(x => x.UniqueIdentifier);
            return readedData;
        }
        public static void WriteData<T>(string path, List<T> list)
        {
            var type = typeof(T);
            var property = type.GetProperties();
            List<string> data = new List<string>();
            foreach (var e in list)
            {
                List<object> temp = new List<object>();

                foreach (var item in property)
                {
                    temp.Add(item.GetValue(e));
                }
                data.Add(string.Join(",", temp));
            }
            File.WriteAllLines(path, data);
        }
        public static void AddMaintenanceShelter(MaintenanceShelter data)
        {
            msID++;
            data.UniqueIdentifier = msID;
            mainShelters.Add(data);
        }

        private static List<MunicipalContract> ReadDataMContract()
        {
            var path = Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "DataBaseFile\\DataContracts.txt");

            var readedData = ReadTxt(path)
                .Select(x => new MunicipalContract(x)).ToList();
            mcID = readedData.Max(x => x.MunicipalContractID);
            return readedData;
        }

        private static List<Organization> ReadDataOrganization()
        {
            var path = Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "DataBaseFile\\DataOrganizations.txt");

            var readedData = ReadTxt(path)
                .Select(x => new Organization(x)).ToList();
            orgID = readedData.Max(x => x.OrganizationID);
            return readedData;
        }
    }
}
