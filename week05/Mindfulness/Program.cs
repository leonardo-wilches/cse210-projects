using System;

class Program
{
    // Leonardo Wilches - W05 Mindfilness Program
    // To add creativity, I included two more activities: one listing things you're grateful for and another stretching session.

    static void Main(string[] args)
    {
        string menu = "";

        while (menu != "6")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. Start Relaxing Activity");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();
            Console.Clear();

            if (menu == "1")
            {
                BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                a1.Run();
            }
            else if (menu == "2")
            {
                ReflectingActivity a2 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                a2.Run();
            }
            else if (menu == "3")
            {
                ListingActivity a3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                a3.Run();
            }
            else if (menu == "4")
            {
                GratitudeActivity a4 = new GratitudeActivity("Gratitude Activity", "This activity will help you reflect on the blessings in your life by having you list so many things you are grateful for.", 0);
                a4.Run();
            }
            else if (menu == "5")
            {
                RelaxingActivity a5 = new RelaxingActivity("Relaxing Activity", "This activity will help you helps you relax your body through stretching.", 0);
                a5.Run();
            }
            else
            {
                if (menu != "6")
                {
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        Console.WriteLine("Thanks! Come back soon.");
    }
}