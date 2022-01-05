using Design_Patterns_Assignment.Observer.Interfaces;
using System;
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

        public void NotifySubscriber()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update();
            }
        }

        public void CheckTime()
        {
            var evenMinute = DateTime.Now.Minute % 2;

            if (evenMinute == 0)
            {
                NotifySubscriber();
            }
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