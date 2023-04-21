using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // Lets user know to hit "0" to quit
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");  

        // Empty list named "numbers" generated
        List<int> numbers = new List<int>();

        // Initializes user input thats converted to an integer
        int number = -1;

        // Initializes the default of totaled numbers in the list
        int sum = 0;

        while (number != 0)                     // While the user input isn't equal to "0" the While Loop will run continously
        {
            Console.Write("Enter number: ");    // Asks the user to input a number
            string num = Console.ReadLine();    // Saves the user input inside a variable
            number = int.Parse(num);            // Converts the saved input into an integer to then be saved in another variable

            if (number != 0)                    // Specifies if the user input isn't equal to "0"
            {
                numbers.Add(number);            // Stores user input inside the empty list
            }

        }

        foreach (int numb in numbers)           // For input stored inside of the list
        {
            sum += numb;                        // Add each user input together to create a grand total
        }
        
        Console.WriteLine();                    // Empty space
        Console.WriteLine($"Your sum is: {sum}");   // Tells the user the grand total of the numbers entered

        float aver = ((float)sum) / numbers.Count;  // Divides the grand total by the amount of numbers entered and then stored in the "aver" variable
        Console.WriteLine($"Your average altogether is: {aver}");   // Prints the aver variable to the user letting them know the average

        int largest = numbers[0];           // Initializes the index in the list to variable "largest"

        foreach (int numb in numbers)       // For input stored inside of the list
        {
            if (numb > largest)             // Specifies if the elements inside of list is larger than the "largest" variable
            {
                largest = numb;             // The "largest" variable then equals the biggest number in the list
            }
        }
        
        // Prints out the largest number from the stored inputs inside the list
        Console.WriteLine($"Your largest number is: {largest}");
    }
}