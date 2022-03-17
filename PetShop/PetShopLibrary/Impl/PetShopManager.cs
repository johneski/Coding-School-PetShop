using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public class PetShopManager
    {
        private const string FILE_NAME = "petShop.json";
        private PetShop _petShop;

        public PetShopManager()
        {
            Load();
        }

        public PetShopManager(PetShop petShop)
        {
            _petShop = petShop;
        }

        private void Load()
        {
            if (File.Exists(FILE_NAME))
            {
                string text = File.ReadAllText(FILE_NAME, Encoding.UTF8);
                _petShop = JsonSerializer.Deserialize<PetShop>(text);
                return;
            }

            _petShop = new PetShop();
            
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
        }

        public void Delete<T>() where T : class, new()
        {
            if(T == _petShop.Pets.GetType())
        }

        public List<Customer> GetCustomers()
        {
            return _petShop.Customers;                
        }

        public List<Transaction> GetTransactions()
        {
            return _petShop.Transactions;
        }

        public List<Pet> GetPets()
        {
            return _petShop.Pets;
        }

        public List<PetFood> GetPetFoods()
        {
            return _petShop.PetFoods;
        }

        public List<Employee> GetEmployees()
        {
            return _petShop.Employees;
        }
    }
}
