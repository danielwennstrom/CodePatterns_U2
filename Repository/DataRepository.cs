using Design_Patterns_Assignment.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Repository
{
    internal class DataRepository : IRepository
    {
        SimulatedDatabase simulatedDatabase = new();
        public void SaveToDB(IEntity entity)
        {
            simulatedDatabase.Save(entity);
            Console.WriteLine("Saved");
        }

        public List<IEntity> LoadFromDB()
        {
            var list = simulatedDatabase.Load("123");
            Console.WriteLine("Loading dataset");

            return list;
        }
    }
}