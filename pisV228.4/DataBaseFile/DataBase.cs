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
        private static string userLogin;
        private static string userPassword;
        private static string role;
        private static int municipalContractID;
        public static int number;
        public static decimal costDayMaintenance;
        public static DateTime dateConclusion;
        public static DateTime dateAction;
        public static string contractor;
        public static string customer;

        private static List<Animal> animals = ReadDataAnimals(); /*= new List<Animal>()
        {
            new Animal(new object[]{1, "Матмассы", "Собака", "М", "01.01.2012", 1234, "Боня", "Черно-белая", "Ошейник", @"C:\Users\mk19\source\repos\pisV228.4\pisV228.4\PictureAnimal\QPBaStuDUlw.jpg"})
        };*/
        public static List<MaintenanceShelter> mainShelters = ReadDataMS();//= new List<MaintenanceShelter>();

        public static List<Organization> organizations = new List<Organization>();

        public static List<MunicipalContract> municipalContracts = new List<MunicipalContract>();

        public static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            user.login = userLogin;
            user.password = userPassword;
            user.role = role;
            users.Add(user);
        }

        public static User GetUser(string login, string password)
        {
            for(int i = 0; i < users.Count; i++)
            {
                if((users[i].login == login) && (users[i].password == password))
                {
                    return users[i];
                }              
            }
            throw new Exception("Данные введены неверно или пользователя не существует!");
        }
        public static void AddAnimal(Animal data)
        {
            animalID++;
            data.AnimalID = animalID;
            animals.Add(data);
        }

        public static List<Animal> GetAnimals()
        {
            return animals;
        }

        public static Animal GetAnimalCard(int id)
        {
            return animals.First(x => x.AnimalID == id);
        }

        private static List<object[]> ReadTxt(string path)
        {
            var text = File.ReadAllLines(path);
            var array = text.Where(line => line.Length != 0).Select(x => x.Split(',') as object[]).ToList();
            return array;
        }
        private static List<Animal> ReadDataAnimals()
        {
            var readedData = ReadTxt("DataAnimals.txt")
                .Select(x=> new Animal(x)).ToList();
            animalID = readedData.Max(x=>x.AnimalID);
            return readedData;
        }
        /*public static void WriteDataAnimals()
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
        }*/

        public static void WriteDataAnimals()
        {
            WriteData("DataAnimal.txt", animals);
            //File.WriteAllLines(, data);
        }

        private static List<MaintenanceShelter> ReadDataMS()
        {
            var readedData = ReadTxt("DataMainShelters.txt")
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

        public static List<MaintenanceShelter> GetMaintenanceShelter()
        {
            return mainShelters;
        }

        public static void AddMunicipalContract(MunicipalContract contract)
        {
            municipalContractID++;
            contract.Contractor = contractor;
            contract.CostDayMaintenance = costDayMaintenance;
            contract.Customer = customer;
            contract.DateAction = dateAction;
            contract.DateConclusion = dateConclusion;
            contract.Number = number;
            municipalContracts.Add(contract);
        }

        public static List<MunicipalContract> GetMunicipalContract()
        {
            return municipalContracts;
        }
    }
}
