using Design_Patterns_Assignment.Observer.Interfaces;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Observer
{
    internal class Server : IServer
    {
        public Server()
        {
            Subscribers = new();
        }

        public List<ISubscriber> Subscribers { get; set; }

        public string NotifySubscriber()
        {
            foreach (var subscriber in Subscribers)
            {
                return subscriber.Update();
            }
            return null;
        }

        public void RegisterSubscriber(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void UnregisterSubsriber(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }
    }
}