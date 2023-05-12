class ListingActivity : Activity
{
    public ListingActivity (string activity, string describe, int time) : 
    base (activity, describe, time)
    {
        
    }
    private List<string> entries = new List<string>{};
    public void DisplayListing()
    {
        ActivityDisplay();
        GetDuration();

        Inform();

         _duration = DateTime.Now;
        DateTime endTime = GetDuration();
        while (_duration < endTime)
        {
            Console.Write(">");
            string list = Console.ReadLine();
            entries.Add(list);
            _duration = DateTime.Now;
        }
        Console.WriteLine($"You have entered {entries.Count()} items.");
        Console.WriteLine();
        Thread.Sleep(1700);
        Console.Clear();
        End();
        Console.Clear();

    }

    public void GetListingPrompt()
    {
        List<string> listing = new List<string>
        {
            "--Who are people that you appreciate?--",
            "--What are personal strengths of yours?--",
            "--Who are people that you have helped this week?--",
            "--When have you felt the Holy Ghost this month?--",
            "--Who are some of your personal heroes?--"
        };
        Random rand = new Random();
        int index = rand.Next(listing.Count);
        string listPrompt = listing[index];
        Console.WriteLine($"{listPrompt}");

    }

    public void Inform()
    {
        Console.WriteLine();
        Console.Clear();
        Console.Write("Get ready...");
        Spinner();

        Console.Clear();
        GetListingPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        
        Console.WriteLine();
        Console.Write("You may begin in: ");
        CountUp();
        Console.WriteLine();
    }
}