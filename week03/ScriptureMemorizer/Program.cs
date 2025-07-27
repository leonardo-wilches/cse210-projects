using System;

class Program
{
    // To add creativity I added a section where you have to guess the Scripture.
    // Therefore there are 2 activities, one rune to memorize and another to guess.
    static void Main(string[] args)
    {
        string menuInput = "";

        while (menuInput != "3")
        {
            Console.WriteLine("Memory Game");
            Console.WriteLine("1. Memorize the Scripture");
            Console.WriteLine("2. Guess the Scripture");
            Console.WriteLine("3. Quit");
            Console.Write("Please select an option: ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                Scripture scripture = SelectScripture();

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nPress enter to hide more words or type 'quit' to return to the menu.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        break;

                    scripture.HideRandomWords(3);
                }

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to return to menu.");
                Console.ReadLine();
            }
            else if (menuInput == "2")
            {
                List<Scripture> scriptures = new List<Scripture>
                {
                    new Scripture(new Reference("John", 3, 16),
                        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                    new Scripture(new Reference("2 Nephi", 2, 24, 25),
                        "But behold, all things have been done in the wisdom of him who knoweth all things.\nAdam fell that men might be; and men are, that they might have joy."),
                    new Scripture(new Reference("Doctrine and Covenants", 18, 10),
                        "Remember the worth of souls is great in the sight of God.")
                };

                Random rnd = new Random();
                int correctIndex = rnd.Next(scriptures.Count);
                Scripture correctScripture = scriptures[correctIndex];

                Console.Clear();
                Console.WriteLine("Guess the Scripture:\n");
                Console.WriteLine(correctScripture.GetFullTextOnly());
                Console.WriteLine("\nWhat is the reference?");
                Console.WriteLine("1. John 3:16");
                Console.WriteLine("2. 2 Nephi 2:25-26");
                Console.WriteLine("3. Doctrine and Covenants 18:10");
                Console.Write("\nEnter the number of your choice: ");
                string userChoice = Console.ReadLine();

                if ((userChoice == "1" && correctIndex == 0) ||
                    (userChoice == "2" && correctIndex == 1) ||
                    (userChoice == "3" && correctIndex == 2))
                {
                    Console.WriteLine("Correct! Well done!\n");
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was: {correctScripture.GetReferenceText()}\n");
                }
            }
        }
        Console.WriteLine("\nThanks for playing, keep memorizing.");
    }

    //

    static Scripture SelectScripture()
    {
        Console.Clear();
        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("\n1. John 3:16");
        Console.WriteLine("2. 2 Nephi 2:24-25");
        Console.WriteLine("3. Doctrine and Covenants 18:10");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        if (choice == "2")
        {
            Reference r = new Reference("2 Nephi", 2, 24, 25);
            string t = "But behold, all things have been done in the wisdom of him who knoweth all things.\nAdam fell that men might be; and men are, that they might have joy.";
            return new Scripture(r, t);
        }
        else if (choice == "3")
        {
            Reference r = new Reference("Doctrine and Convenants", 18, 10);
            string t = "Remember the worth of souls is great in the sight of God.";
            return new Scripture(r, t);
        }
        else
        {
            Reference r = new Reference("John", 3, 16);
            string t = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            return new Scripture(r, t);
        }
    }
}