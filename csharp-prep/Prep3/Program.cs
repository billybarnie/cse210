using System;

class Program
{
    static void Main(string[] args)
    {   
        // Initializes string for yes/no game replay 
        string input;
    
        // Initializes string parse to integer
        int guess = -1;

        // Initializes guess count
        int count = 1;

        // Defines program
        Console.WriteLine("The purpose of this game is to find the magic number...");

        // Empty space
        Console.WriteLine();

        do
        {
        
        // Random number generator
        Random randGen = new Random();      // Initializes Random generator
        int num = randGen.Next(1, 100);     // Places random number generator inside a variable and specifies its ceiling

        // Asks the user for the magi number and gives it all on one line
        Console.Write($"What is the magic number? {num}");

            do      // Start of Do-While Loop
            {
                Console.Write("What is your guess? ");  // Asks user to input guess
                string numb = Console.ReadLine();       // Saves user entered number to a string variable
                guess = int.Parse(numb);                // Converts string variable saved to integer to be compared

                if (guess > num)                        // Specifies integer as being greater than random gen number
                {
                    Console.WriteLine("Lower");         // Tells the user to enter a lower number
                    count += 1;                         // Adds a plus one to the guess count
                }
                else if (guess < num)                   // Specifies integer as being less than random gen number
                {
                    Console.WriteLine("Higher");        // Tells the user to enter a higher number
                    count += 1;                         // Adds a plus one to the guess count
                }
                else if (guess == num)                  // Specifies integer as being equal to the random gen number
                {   
                    Console.WriteLine();                                // Empty space
                    Console.WriteLine("Congrats!! You got it!!");       // Congratulates the user
                    Console.WriteLine($"It took you {count} tries!");   // Lets user know the number of guesses entered
                }
            } while (guess != num);                         // End of Do-While Loop and set guess not being equal to random gen number by default

        Console.WriteLine();                                // Empty space
        Console.Write("Would you like to play again? ");    // Asks the user if they would like to play again
        input = Console.ReadLine();                         // Saves and reads users input inside a variable
        Console.WriteLine();                                // Empty space
        count = 1;                  // Sets guess count back to default

        } while (input == "yes");   // End of Do-While Loop and sets saved user input to yes by default
    }
}