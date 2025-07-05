using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string inputName = PromptUserName();
        int inputNumber = PromptUserNumber();
        int squareNumber = SquareNumber(inputNumber);

        DisplayResult(inputName, squareNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}