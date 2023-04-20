using System;

class Program
{
    static void Main(string[] args)
    {   
        // Initializes string for yes/no game replay 
        string input;
    
        // Initializes string parse to integer
        int guess = -1;

        int count = 1;

        // Defines program
        Console.WriteLine("The purpose of this game is to find the magic number...");

        // Empty space
        Console.WriteLine();

        do
        {
        
        // Random number generator
        Random randGen = new Random();
        int num = randGen.Next(1, 100);

            do 
            {
                Console.Write("What is your guess? ");
                string numb = Console.ReadLine();
                guess = int.Parse(numb);

                if (guess > num) 
                {
                    Console.WriteLine("Lower");
                    count += 1;
                }
                else if (guess < num) 
                {
                    Console.WriteLine("Higher");
                    count += 1;
                }
                else if (guess == num)
                {   
                    Console.WriteLine();
                    Console.WriteLine("Congrats!! You got it!!");
                    Console.WriteLine($"It took you {count} tries!");
                }
            } while (guess != num);

        Console.WriteLine();
        Console.Write("Would you like to play again? ");
        input = Console.ReadLine();
        Console.WriteLine();
        count = 1;

        } while (input == "yes");
    }
}