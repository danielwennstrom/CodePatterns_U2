namespace Design_Patterns_Assignment.Strategy.Interfaces
{
    internal interface IMessageHandler
    {
        IService Service { get; set; }

        void Send(string text);

        void SetService(IService service);
    }
}