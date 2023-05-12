
class ReflectingActivity: Activity
{
    
    public ReflectingActivity (string activity, string describe, int time) : 
    base (activity, describe, time)
    {
        
    }
    
    public void DisplayReflecting()
    {
        ActivityDisplay();
        GetDuration();

        Instructions();

        _duration = DateTime.Now;
        DateTime endTime = GetDuration();
        while (_duration < endTime)
        {

            GetRandomQuestion();
            Spinner();
            Console.WriteLine();
            _duration = DateTime.Now;
        }
        Console.WriteLine();
        End();
        Console.Clear();
    }


    public void GetReflectingPrompt()
    {
        List<string> _prompt = new List<string>
        {
            "--Think of a time when you stood up for someone else.--",
            "--Think of a time when you did something really difficult.--",
            "--Think of a time when you helped someone in need.--",
            "--Think of a time when you did something truly selfless.--"
        };
        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        string prompt = _prompt[index];
        Console.WriteLine($"{prompt}");

    }

    public void GetRandomQuestion()
    {
        List<string> _question = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

        Random rand = new Random();
        int index = rand.Next(_question.Count);
        string question = _question[index];
        Console.Write($"\n{question} ");

    }

    public void Instructions()
    {
        Console.Clear();
        Console.Write("Get Ready...");
        Spinner();

        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        GetReflectingPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter.");
        string input = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Now ponder on each of the following questions as they related to this experience. ");
        Console.WriteLine();
        Console.Write("You may begin in...");
        CountUp();
        Console.Clear();
    }
}