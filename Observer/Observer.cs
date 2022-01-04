using System;

namespace Design_Patterns_Assignment.Observer
{
    internal class Observer
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            Server server = new();
            Subscriber subscriber = new();
            Subscriber subscriber1 = new();
            server.RegisterSubscriber(subscriber);
            server.RegisterSubscriber(subscriber1);
            int evenMinute;

            while (true)
            {
                evenMinute = DateTime.Now.Minute % 2;
                if (evenMinute == 0)
                {
                    server.NotifySubscriber();
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}