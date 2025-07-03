using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_named = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_named = Console.ReadLine();

        Console.WriteLine($"Your name is {last_named}, {first_named} {last_named}.");
    }
}