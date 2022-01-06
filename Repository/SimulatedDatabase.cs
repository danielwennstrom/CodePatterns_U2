using Design_Patterns_Assignment.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    internal class SimulatedDatabase : ISimulatedDatabase
    {
        List<IEntity> Database;
        public SimulatedDatabase()
        {
            Database = new();
        }
        public List<IEntity> Load(string connectionString)
        {
            return Database;
        }

        public void Save(IEntity entity)
        {
            Database.Add(entity);
        }
    }
}
