using Design_Patterns_Assignment.Repository.Interfaces;

namespace Design_Patterns_Assignment.Repository
{
    internal class Animal : IAnimal
    {
        public Animal(int id, string owner)
        {
            Owner = owner;
            Id = id;
        }

        public string Owner { get; set; }

        public int Id { get; set; }
    }
}