class EternalGoal : Goal
{
    private const int goalType = 3;
    private bool _complete;
    public EternalGoal() {}

    public EternalGoal(string _goalName, string _description, int _pointAmount) : 
    base (_goalName, _description, _pointAmount) 
    {
        _complete = false;
    }

    public override string ToString()
    {
        return string.Format ("[{0}] {1} ({2})", ( (_complete == false) ? " " : "x"), GetGoalName(), GetGoalDescription()) ;
    }

    public override string RecordToCSV()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, GetGoalName(), GetGoalDescription(), GetPointAmount(), _complete);
    }
    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congradulations! You got {0} more points", GetPointAmount()));
        _complete = false;
    }
}