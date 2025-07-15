using System;

class Program
{
    static void Main(string[] args)
    {
        //Leonardo Wilches - W02 Project: Journal Program

        //To add creativity, I added an initial password to access the journal because it's important for the privacy of a journal.
        //This password is "week2." If entered incorrectly, the program ends.
        //It can be modified within the program (only during the current session), and you will be prompted fot the password to save and upload files.
        //However, in this last case, if entered incorrectly, you will simply return to the main menu.

        string password = "week2";

        Console.Write("Enter password to access your journal: ");
        string input = Console.ReadLine();
        Console.WriteLine("");
        if (input != password)
        {
            Console.WriteLine("Incorrect password. Exiting the journal.");
            return;
        }

        string userInput;
        Journal myJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Change Password");
            Console.WriteLine("6. Quit");
            Console.Write("What do you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("");
                Entry write = new Entry();
                write.Display();

                myJournal.AddEntry(write);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("");
                myJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("");
                Console.Write("Enter password to save: ");
                string inputSave = Console.ReadLine();
                if (inputSave == password)
                {
                    Console.Write("File name to save: ");
                    string filename = Console.ReadLine();
                    myJournal.SaveToFile(filename);
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                    Console.WriteLine("");
                }
            }
            else if (userInput == "4")
            {
                Console.WriteLine("");
                Console.Write("Enter password to load: ");
                string inputLoad = Console.ReadLine();
                if (inputLoad == password)
                {
                    Console.Write("File name: ");
                    string filename = Console.ReadLine();
                    myJournal.LoadToFile(filename);
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                    Console.WriteLine("");
                }
            }
            else if (userInput == "5")
            {
                Console.WriteLine("");
                Console.Write("Enter current password: ");
                string oldPassword = Console.ReadLine();
                if (oldPassword == password)
                {
                    Console.Write("Enter new password: ");
                    string newPassword = Console.ReadLine();
                    password = newPassword;
                    Console.WriteLine("Password updated successfully for this session only.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                    Console.WriteLine("");
                }
            }

        } while (userInput != "6");

        Console.WriteLine("");
        Console.WriteLine("Remember smile and have a nice day, bye.");
    }
}