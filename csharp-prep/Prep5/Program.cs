using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter you name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string favoriteNumber = Console.ReadLine();
        int number = int.Parse(favoriteNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int sum = number * number;
        return sum;
    }

    static void DisplayResult(string name, int sum)
    {
        Console.WriteLine($"{name}, the square of your number is {sum}");
    }
}