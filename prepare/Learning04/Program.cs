using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simple = new Assignment("Samuel Bennett", "Mulitplication");
        Console.WriteLine(simple.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions","7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment historyClass = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(historyClass.GetSummary());
        Console.WriteLine(historyClass.GetWritingInformation());
    }
}