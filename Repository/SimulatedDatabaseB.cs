using Design_Patterns_Assignment.Repository.Interfaces;

namespace Design_Patterns_Assignment.Repository
{
    internal class SimulatedDatabaseB<T> : DataRepository<T>, ISimulatedDatabaseB<T> where T : class
    {
    }
}