namespace Design_Patterns_Assignment.Strategy.Interfaces
{
    internal interface IService
    {
        string Service { get; set; }

        void Send(string text);
    }
}