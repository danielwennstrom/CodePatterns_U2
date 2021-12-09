using System;

namespace Design_Patterns_Assignment.Decorator
{
    internal class Decorator
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            HTMLGenerator generator = new();
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            string textInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bold");
            Console.WriteLine("Deleted");
            Console.WriteLine("Emphasized");
            Console.WriteLine("Important");
            Console.WriteLine();
            Console.WriteLine("Type the tags you want separated by space");
            string tagSelection = Console.ReadLine();
            string result = generator.TagProcessor(tagSelection, textInput);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}