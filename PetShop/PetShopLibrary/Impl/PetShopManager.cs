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

        public void Delete(Customer customer) 
        {
            customer.ObjectStatus = DataObjects.Status.Inactive;
        }

        public void Delete(Employee employee)
        {
            employee.ObjectStatus = DataObjects.Status.Inactive;
        }

        public void Delete(Pet pet)
        {
            pet.ObjectStatus = DataObjects.Status.Inactive;
        }


        public void Delete(PetFood petFood)
        {
            petFood.ObjectStatus = DataObjects.Status.Inactive;
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

        public void Add(Customer customer)
        {
            _petShop.Customers.Add(customer);
        }

        public void Add(Employee employee)
        {
            _petShop.Employees.Add(employee);
        }

        public void Add(Pet pet)
        {
            _petShop.Pets.Add(pet);
        }

        public void Add(Transaction transaction)
        {
            _petShop.Transactions.Add(transaction);
        }

        public void Add(PetFood petFood)
        {
            _petShop.PetFoods.Add(petFood);
        }

        public 

    }
}
