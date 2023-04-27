using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        int userInput = 0;

        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do? "
            };

        while (userInput != 5)
        {
            foreach(string item in menu)
            {
                Console.WriteLine(item);
            }
            userInput = int.Parse(Console.ReadLine());
            
            switch (userInput)
            {   
                case 1:
                    journal.MakeEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntry();
                    break;
                case 3:
                    journal.LoadCSV();
                    break;
                case 4:
                    journal.SaveCSV();
                    break;
            }
        }   

    }
}