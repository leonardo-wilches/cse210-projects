using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1 - Leonardo Wilches

        Console.Write("What is your first name? ");
        string firstNamed = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastNamed = Console.ReadLine();

        Console.WriteLine($"Your name is {lastNamed}, {firstNamed} {lastNamed}.");
    }
}