using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks the user for their grade in class
        Console.Write("What was your grade percentile in CSE 210? ");
        string grade = Console.ReadLine();

        // Converts grade string to integer
        int number = int.Parse(grade);

        // Q/A Gap
        Console.WriteLine();

        // Initiates letter grade
        string letter = "";

        // Calculates number grade based on percentile entered
        if (number >= 93)
        {   
            letter = "A";
        }
        else if (number < 93 && number >= 90)
        {
            letter = "A-";
        }
        else if (number >= 87 && number < 90)
        {
            letter = "B+";
        }
        else if (number >= 83)
        {
            letter = "B";
        }
        else if (number < 83 && number >= 80)
        {
            letter = "B-";
        }
        else if (number >= 77 && number < 80)
        {
            letter = "C+";
        }
        else if (number >= 73)
        {
            letter = "C";
        }
        else if (number < 73 && number >= 70)
        {
            letter = "C-";
        }
        else if (number >= 67 && number < 70)
        {
            letter = "D+";
        }
        else if (number >= 63)
        {
            letter = "D";
        }
        else if (number < 63 && number >= 60)
        {
            letter = "D-";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        // Calculates whether user percentile entered is passing or not
        if (number >= 70)
        {
            Console.WriteLine("Congradulations!! You Passed CSE 210!");
        }
        else
        {
            Console.WriteLine("You will do better next time I am sure!");
        }
    }
}