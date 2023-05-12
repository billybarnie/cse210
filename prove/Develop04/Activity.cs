class Activity
{
    private string _activity;

    private string _describe;

    protected DateTime _duration;

    protected int _time;

    public Activity (string activity, string describe, int time)
    {
        _activity       = activity;
        _describe       = describe;
        _time           = time;
    }
    public string GetStart()
    {
        return $"Welcome this is the {_activity}";
    }

    public string GetDescription()
    {
        
        return $"{_describe}";
    }

    public DateTime GetDuration()
    {   
        int seconds = _time;
        _duration = DateTime.Now;
        DateTime endTime = _duration.AddSeconds(seconds);

        return endTime;
    }

    public void CountUp()
    {
        for (int i = 1; i < 6; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner()
    {
        List<string> spin = new List<string>();

        spin.Add("|");
        spin.Add("/");
        spin.Add("-");
        spin.Add("\\");
        spin.Add("|");
        spin.Add("/");
        spin.Add("-");
        spin.Add("\\");
        spin.Add("|");
        spin.Add("/");

        foreach (string s in spin)
        {
            Console.Write(s);
            Thread.Sleep(850);
            Console.Write("\b \b");
        }
    }

    public void ActivityDisplay()
    {
        string activity = GetStart();
        Console.WriteLine(activity);

        Console.WriteLine();
        string describe = GetDescription();
        Console.WriteLine(describe);

        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your your lesson to be? ");
        string userInput = Console.ReadLine();
        _time = int.Parse(userInput);

    }

    public void End()
    {
        Console.WriteLine("Well done!");
        Console.Write($"You have completed another {_time} seconds of the {_activity}");
        Dots();
    }
    public void Dots()
    {
        for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
    }

}