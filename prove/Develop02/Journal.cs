
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
                newFile.WriteLine(entry.EntryAsCSV().Trim());
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

        // If user inputs "yes" executes the following code
        if (yes == "yes")
        {
            // The entries List is Cleared of all data
            entries.Clear();

            // Iterates through each block in the file that is being loaded as requested
            foreach (string block in lines)
            {   
                // The block is split by "|" and saved into the part variable
                string[] part = block.Split("|");
                // The third index is saved inside of the response variable
                string response = part[2].Trim();
                // The second index is saved inside of the prompt variable
                string prompt = part[1].Trim();
                // The first index is saved inside of the date variable
                string date = part[0].Trim();

                // A new Entry object is created and named "newentry"
                Entry newentry = new Entry(date,prompt,response);

                // The "newentry" object is then added to the entries List
                entries.Add(newentry);

                /* The data is being cleared to overwrite the data the user has previously entered
                   being that they were asked if they would like to overwrite the current data that 
                   they have entered if that have entered any data. From there the load file then 
                   stores all the data from the file that they had requested to the "entries" list in 
                   the format of {date}, {prompt}, {response}. In doing so they have then added the 
                   file of journal entries requested to their journal.
                */

            }
        }

        // If user inputs "no" executes the following code
        else if (yes == "no")
        {   
            // Iterates through each block in the file that is being loaded as requested
            foreach (string block in lines)
            {
                // The block is split by "|" and saved into the part variable
                string[] part = block.Split("|");
                // The third index is saved inside of the response variable
                string response = part[2].Trim();
                // The second index is saved inside of the prompt variable
                string prompt = part[1].Trim();
                // The first index is saved inside of the date variable
                string date = part[0].Trim();

                // A new Entry object is created and named "newentry"
                Entry newentry = new Entry(date,prompt,response);

                // The "newentry" object is then added to the entries List
                entries.Add(newentry);

                /* The data does not get cleared because the user decided not you overwrite any 
                   current data that they had made as far as entries. The file that the user 
                   requested is then loaded into the "entries" List in the same format that 
                   it would be had had the overwritten as follows {date}, {prompt}, {response}.
                   All entries they have entered plus the file requested contents will be added 
                   together and it will be clearly seen when they use the display option(2). They 
                   can also add the same file or multiple other files to add all the responses 
                   together with ease.
                */

            }
        }
    }

}