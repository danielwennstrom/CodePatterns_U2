using System.Collections.Generic;

namespace Design_Patterns_Assignment.Observer.Interfaces
{
    public interface IServer
    {
        List<ISubscriber> Subscribers { get; set; }

        void RegisterSubscriber(ISubscriber subscriber);

        void UnregisterSubsriber(ISubscriber subscriber);

        void NotifySubscriber();

        void CheckTime();
    }
}