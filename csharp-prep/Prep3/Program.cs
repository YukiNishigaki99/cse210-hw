using System;
using System.IO.Pipelines;
// instruction:
// https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput1 = Console.ReadLine();
        // int magicNumber = int.Parse(userInput1);

        // Generate random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);


        string result = "";
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            // guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                result = "Lower";
                Console.WriteLine(result);
            }
            else if (guess > magicNumber)
            {
                result = "Higher";
                Console.WriteLine(result);
            }        
            else
            {
                result = "You guessed it!";
                Console.WriteLine(result);
            };
        };
    }
}