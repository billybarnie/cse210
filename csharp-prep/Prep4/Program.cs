using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();

        int number = -1;

        int sum = 0;

        

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            number = int.Parse(num);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        foreach (int numb in numbers)
        {
            sum += numb;
        }
        
        Console.WriteLine($"Your sum is: {sum}");

        float aver = ((float)sum) / numbers.Count;
        Console.WriteLine($"Your average altogether is: {aver}");

        int largest = numbers[0];
        
        foreach (int numb in numbers)
        {
            if (numb > largest)
            {
                largest = numb;
            }
        }
        
        Console.WriteLine($"Your largest number is: {largest}");
    }
}