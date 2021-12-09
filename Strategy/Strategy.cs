using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Strategy
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            SMS sms = new();
            FBMessenger fbMessenger = new();
            Email email = new();
            MessageHandler messageHandler = new();
            messageHandler.SetService(sms);
            messageHandler.Send("text 1");
            messageHandler.SetService(fbMessenger);
            messageHandler.Send("text 2");
            messageHandler.SetService(email);
            messageHandler.Send("text 3");

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message
        }
    }
}