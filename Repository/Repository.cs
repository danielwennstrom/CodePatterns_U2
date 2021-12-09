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

            SimulatedDatabase<Customer> simulatedDatabase = new();
            List<Customer> customerList = simulatedDatabase.Load("blablabla");
            simulatedDatabase.Save(customerA, customerList);
            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.Name}");
            }

            SimulatedDatabaseB<Animal> simulatedDatabaseB = new();
            List<Animal> animalList = simulatedDatabaseB.Load("blablabla");
            simulatedDatabaseB.Save(animalA, animalList);
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Owner}");
            }
        }
    }
}