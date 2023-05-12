
class BreathingActivity : Activity
{

    public BreathingActivity (string activity, string describe, int time) : 
    base (activity, describe, time)
    {

    }

    public void BreatheIn()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in...");
        CountUp();
    }

    public void BreatheOut()
    {   
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe out...");
        CountUp();
    }
    public void DisplayBreathing()
    {
        ActivityDisplay();

        DateTime endTime = GetDuration();
        Console.Clear();
        while (_duration < endTime)
        {
            BreatheIn();
            BreatheOut();
            _duration = DateTime.Now;
        }
        Console.Clear();
        End();
        Console.Clear();
    }
}