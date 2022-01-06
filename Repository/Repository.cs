using Design_Patterns_Assignment.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment.Repository
{
    internal class Repository
    {
        internal static void Run()
        {
            Console.WriteLine("Repository");
            ICustomer customerA = new Customer(1, "Olof");
            IAnimal animalA = new Animal(1, "Ture");

            DataRepository dataRepository = new();
            var database = dataRepository.LoadFromDB();
            dataRepository.SaveToDB(customerA);
            var customerList = database.OfType<ICustomer>();

            dataRepository.SaveToDB(animalA);
            var animalList = database.OfType<IAnimal>();

            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.Name}");
            }
            
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Owner}");
            }
        }
    }
}