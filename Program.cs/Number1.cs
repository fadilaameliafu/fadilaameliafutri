using System;
 
namespace UserInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me about yourself.");
            Console.Write("Type your first name: ");
 
            string myFirstName;
            myFirstName = Console.ReadLine();
            
            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();
 
            Console.WriteLine();
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
 
            Console.ReadLine();
        }
    }
}