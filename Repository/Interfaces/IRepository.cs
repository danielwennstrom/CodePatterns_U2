using System.Collections.Generic;

namespace Design_Patterns_Assignment.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Save(T entity, List<T> list);

        List<T> Load(string connectionstring);
    }
}