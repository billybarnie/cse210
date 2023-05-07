using System;

class Program
{
    static void Main(string[] args)
    {
        Proverbs proverb = new Proverbs();
        var proverbElem = proverb.ProverbElement();

        Reference scriptureRef = new Reference(proverbElem.Item1, proverbElem.Item2, proverbElem.Item3);
        Scripture script = new Scripture(scriptureRef, proverbElem.Item4);

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