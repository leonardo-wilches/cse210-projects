using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = null;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int userGuess;
            int guesses = 1;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                userGuess = int.Parse(guess);

                if (userGuess == number)
                {
                    Console.WriteLine($"You guessed it in {guesses} tries!");
                    Console.WriteLine("Do want to play again?");
                    answer = Console.ReadLine();
                }
                else if (userGuess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

                guesses++;
            } while (userGuess != number);
        } while (answer == "yes");

        Console.WriteLine("Thanks for playing!");
    }    
}