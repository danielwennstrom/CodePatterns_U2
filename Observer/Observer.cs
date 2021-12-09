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
            server.RegisterSubscriber(subscriber);
            var email = "";

            while (string.IsNullOrEmpty(email))
            {
                email = server.NotifySubscriber();
            }
            Console.WriteLine();
        }
    }
}