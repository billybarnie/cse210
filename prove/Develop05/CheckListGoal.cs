class ChecklistGoal : Goal
{
    private const int goalType = 2;
    private int _timesCompleted;
    private int numberForBonus;

    public ChecklistGoal() 
    {_complete = false;}

    public ChecklistGoal(string _goalName, string _description, int _pointAmount, int timesCompleted, int timesToComplete, int bonusPoints, bool complete)
    : base (_goalName, _description, _pointAmount)
    {
        _timesCompleted     = timesCompleted;
        _bonusPoints        = bonusPoints;
        _timesToComplete    = timesToComplete;
        _complete           = complete;
    }

    public override string ToString()
    {
        return string.Format ("[{0}] {1} ({2}) <---- {3}/{4}", ( (_complete == false) ? " " : "x"), 
        GetGoalName(), GetGoalDescription(), _timesCompleted, _timesToComplete);
    }

    public void NumberOfTimes()
    {
        Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
        numberForBonus = int.Parse(Console.ReadLine());
    }

    public override string RecordToCSV()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", goalType, GetGoalName(), GetGoalDescription(), GetPointAmount(), 
        _timesCompleted, _timesToComplete, _bonusPoints, _complete);
    }

    public override int GetPointAmount()
    {
        if (_complete == true)
        {
            return _bonusPoints;
        }
        else
        {   
            return base.GetPointAmount();
        }
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine();
        _timesCompleted ++;
        if (_timesCompleted >= _timesToComplete)
        {
            _complete = true;
        }
        
        Console.WriteLine(string.Format("Congradulations! You got {0} more points", GetPointAmount()));
    }
}