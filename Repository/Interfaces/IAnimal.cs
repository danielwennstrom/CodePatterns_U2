namespace Design_Patterns_Assignment.Repository.Interfaces
{
    internal interface IAnimal : IEntity
    {
        string Owner { get; set; }
    }
}