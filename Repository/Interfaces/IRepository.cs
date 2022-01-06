using System.Collections.Generic;

namespace Design_Patterns_Assignment.Repository.Interfaces
{
    public interface IRepository
    {
        void SaveToDB(IEntity entity);

        List<IEntity> LoadFromDB();
    }
}