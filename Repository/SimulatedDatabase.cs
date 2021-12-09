using Design_Patterns_Assignment.Repository.Interfaces;

namespace Design_Patterns_Assignment.Repository
{
    internal class SimulatedDatabase<T> : DataRepository<T>, ISimulatedDatabase<T> where T : class
    {
    }
}