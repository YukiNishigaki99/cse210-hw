using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float percentage = float.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            // Console.WriteLine("A");
            letter = "A";
        }
        else if (percentage < 90 && percentage >= 80)
        {
            // Console.WriteLine("B");
            letter = "B";
        }
        else if (percentage < 80 && percentage >= 70)
        {
            // Console.WriteLine("C");
            letter = "C";
        }
        else if (percentage < 70 && percentage >= 60)
        {
            // Console.WriteLine("D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("F");
            letter = "F";
        }

        Console.WriteLine(letter);

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep trying next time!");
        }

    }
}