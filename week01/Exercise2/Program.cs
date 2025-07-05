using System;

class Program
{
    static void Main(string[] args)
    {
        // exercise 2 - Leonardo Wilches

        Console.Write("What is your grade percentaje?: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        
        string letter = null;

        int gradeDivided = grade % 10;
        string sign = null;

        // Grade Calculation

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Letter Calculation

        if (gradeDivided >= 7 && grade < 93 && grade >= 67)
        {
            sign = "+";
        }
        else if (gradeDivided < 3 && grade >= 60 && grade != 100)
        {
            sign = "-";
        }
        else
        {
            sign = null;
        }

        if (grade >= 70)
        {
            Console.WriteLine($"You grade is: {letter}{sign}");
            Console.WriteLine("Congratulation, you passed the couse!");
        }
        else
        {
            Console.WriteLine($"You grade is: {letter}{sign}");
            Console.WriteLine("You not passed the course, still studying and make an effort for the next time.");
        }
    }
}