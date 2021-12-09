using Design_Patterns_Assignment.Strategy.Interfaces;

namespace Design_Patterns_Assignment.Strategy
{
    internal class MessageHandler : IMessageHandler
    {
        public IService Service { get; set; }

        public void Send(string text)
        {
            Service.Send(text);
        }

        public void SetService(IService service)
        {
            Service = service;
        }
    }
}