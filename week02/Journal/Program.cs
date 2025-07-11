using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        Journal myJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Entry write = new Entry();
                write.Display();

                myJournal.AddEntry(write);
            }
            else if (userInput == "2")
            {
                myJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.Write("File name to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userInput == "4")
            {
                Console.Write("File name: ");
                string filename = Console.ReadLine();
                myJournal.LoadToFile(filename);
            }

        } while (userInput != "5");
    }
}