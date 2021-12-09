using Design_Patterns_Assignment.Strategy.Interfaces;
using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Email : IService
    {
        public Email()
        {
            Service = "E-mail";
        }

        public string Service { get; set; }

        public void Send(string text)
        {
            Console.WriteLine($"Sending {text} over {this.Service}");
        }
    }
}