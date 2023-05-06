using System;

class Program
{
    static void Main(string[] args)
    {

        Reference scriptureRef = new Reference("Proverbs", "3", "5", "6");
        Scripture script = new Scripture(scriptureRef, "Trust in the LORD with all thine heart; and lean not unto thine own understanding." + 
        "In all thy ways acknowledge him, and he shall direct thy paths.");

        string response = "";

        while (response != "quit" && script.HasWordsLeft()  == true)
        {
            Console.Clear();
            Console.WriteLine(script.DisplayScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            script.RemoveWords();

        }

        Console.Clear();
        Console.WriteLine(script.DisplayScripture());
        Console.WriteLine();

        

    }
}