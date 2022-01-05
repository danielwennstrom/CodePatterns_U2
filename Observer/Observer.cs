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

            Console.WriteLine("1: Register/unregister subscriber");
            Console.WriteLine("2: Update");

            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        if (!server.Subscribers.Contains(subscriber))
                        {
                            Console.WriteLine("registered");
                            server.RegisterSubscriber(subscriber);
                        }
                        else
                        {
                            Console.WriteLine("unregistered");
                            server.UnregisterSubsriber(subscriber);
                        }
                        break;
                    case '2':
                        server.CheckTime();
                        break;
                }
            }
        }
    }
}