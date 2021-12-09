using Design_Patterns_Assignment.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Repository
{
    internal class DataRepository<T> : IRepository<T> where T : class
    {
        public List<T> Load(string connectionstring)
        {
            var retList = new List<T>();
            Console.WriteLine("Loading dataset");
            return retList;
        }

        public void Save(T entity, List<T> list)
        {
            list.Add(entity);
            Console.WriteLine("Saved");
        }
    }
}