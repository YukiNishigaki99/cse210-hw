using System;
// Assignment instruction:
// https://byui-cse.github.io/cse210-course-2023/unit01/csharp-5.html

class Program
{
    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
        // number = int.Parse(Console.ReadLine());

    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    // Accepts out integer parameter and prompts the user for the year they were born.
    // The out parameter is set to their birth year.
    // This function does not return a value.
    // The user's birth year is given back from the function via the out parameter.
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int x)
    {
        int squareNumber = x * x;
        return squareNumber;
    }

    // Accepts the user's name, the squared number, and the user's birth year.
    // Display the user's name and squared number.
    // Calculate hold many years old will turn this year and display that. 
    static  void DisplayResult(string name, int birthYear, int sNumber)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is {sNumber}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

    public static void Main(string[] args)
    {
        int y;
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        // int birthYear = PromptUserBirthYear(out y);
        PromptUserBirthYear(out y);
        int birthYear = y;
        int sNumber = SquareNumber(number);
        DisplayResult(name, birthYear, sNumber);
    }
}