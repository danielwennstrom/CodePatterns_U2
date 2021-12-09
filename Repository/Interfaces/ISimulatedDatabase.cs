namespace Design_Patterns_Assignment.Repository.Interfaces
{
    internal interface ISimulatedDatabase<T> : IRepository<T> where T : class
    {
    }
}