using Design_Patterns_Assignment.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Repository
{
    internal class Repository
    {
        internal static void Run()
        {
            Console.WriteLine("Repository");
            Customer customerA = new Customer(1, "Olof");
            Animal animalA = new Animal(1, "Ture");

            DataRepository<Customer> dataRepository = new();
            List<Customer> customerList = dataRepository.Load("blablabla");
            dataRepository.Save(customerA, customerList);
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.Name}");
            }

            DataRepository<Animal> dataRepositoryB = new();
            List<Animal> animalList = dataRepositoryB.Load("blablabla");
            dataRepositoryB.Save(animalA, animalList);
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Owner}");
            }
        }
    }
}