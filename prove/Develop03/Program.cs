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
    /*  
    The purpose of the Proverbs class is to randomly get a verse 
    from the CSV file and print it to the console. The verse has 
    variables that are assigned and then in the Program class 
    references the proverbElem in the scripture object so that 
    a new verse is gotten each time the program is restarted.
*/
}