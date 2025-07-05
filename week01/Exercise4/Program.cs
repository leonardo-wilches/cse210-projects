using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 4 - Leonardo Wilches

        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        //Sum of numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        float average = ((float)sum) / numbers.Count;

        //Largest number
        int largestNumber = 0;
        foreach (int largest in numbers)
        {
            if (largestNumber < largest)
            {
                largestNumber = largest;
            }
        }

        //Smallest number
        int smallestNumber = largestNumber;
        foreach (int smallest in numbers)
        {
            if (smallestNumber > smallest && smallest > 0)
            {
                smallestNumber = smallest;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

        //Sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int sorted in numbers)
        {
            Console.WriteLine(sorted);
        }
    }
}