using System;
using System.Collections.Generic;
// instruction:
// https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html
class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list.
        // Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Core Requirements 1
        // Compute the sum, or total, of the numbers in the list.
        int total = 0;
        int max = 0;
        foreach (int n in numbers)
        // for (int i = 0; i < numbers.Count; i++)
        {
            total += n;
            // total += numbers[i];

            // Core Requirements 3
            // Find the maxiimum, or largest, number in the list.
            if (n > max)
            // if (numbers[i] > max)
            {
                max = n;
                // max = numbers[i];
            }
        }

        // Core Requirements 2
        // Compute the average of the numbers in the list.
        float average = ((float)total) / numbers.Count;
        // float average = total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}