using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";

        while (menu != "4")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting");
            Console.WriteLine("  3. Start Listing");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();
            Console.Clear();

            if (menu == "1")
            {
                BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                a1.Run();
            } 
        }
    }
}