
class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntry()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void MakeEntry()
    {   
        GenPrompt newPrompt = new GenPrompt();
        string prompt = newPrompt.GetRandomPrompt();

        // Write 'prompt' to the console
        Console.Write(prompt);
        // Create new string variable 'response' and set it equal to a Console.Readline()
        string response = Console.ReadLine();
        // Create new string variable 'date' and set it to Today's date.
        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToShortDateString();
        // Create new Entry object.
        Entry entered = new Entry(date, prompt, response);
        // Add newly created Entry object to 'entries' list.
        entries.Add(entered);

    }

    public void SaveCSV()
    {
        Console.WriteLine("What would you like to save the filename under? ");
        string user = Console.ReadLine();

        string file = user;

        using (StreamWriter newFile = new StreamWriter(file))
        {
            foreach (Entry entry in entries)
            {
                newFile.WriteLine(entry.entryAsCSV());
            }
        }
    }

    public void LoadCSV()
    {
        Console.WriteLine("What file would you like to load? ");
        string load = Console.ReadLine();
        Console.Write("Would you like to overwrite current data if any? ");
        string yes = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(load);

        if (yes == "yes")
        {
            entries.Clear();

            foreach (string block in lines)
            {
                string[] part = block.Split("|");
                string response = part[2];
                string prompt = part[1];
                string date = part[0];

                Entry newentry = new Entry(date,prompt,response);

                entries.Add(newentry);

            }
        }
        else if (yes == "no")
        {
            foreach (string block in lines)
            {
                string[] part = block.Split("|");
                string response = part[2];
                string prompt = part[1];
                string date = part[0];

                Entry newentry = new Entry(date,prompt,response);

                entries.Add(newentry);

            }
        }
    }

}