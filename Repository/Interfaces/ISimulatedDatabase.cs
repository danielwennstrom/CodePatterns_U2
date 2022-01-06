using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Interfaces
{
    internal interface ISimulatedDatabase
    {
        void Save(IEntity entity);
        List<IEntity> Load(string connectionString);
    }
}
