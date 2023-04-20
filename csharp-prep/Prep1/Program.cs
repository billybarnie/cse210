using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking User for their first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        // Asking User for their Last name
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine();

        // Prints their given name first followed by their surname and given name
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}