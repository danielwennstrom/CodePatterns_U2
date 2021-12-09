namespace Design_Patterns_Assignment.Repository.Interfaces
{
    internal class Customer : ICustomer
    {
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}