using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string userInput;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            userInput = Console.ReadLine();
        } while (userInput != "5");
    }
}