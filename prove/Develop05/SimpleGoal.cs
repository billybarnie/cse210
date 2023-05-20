class SimpleGoal : Goal
{
    private const int goalType = 1;

    private bool _complete;

    public SimpleGoal() 
    {_complete = false;}

    public SimpleGoal(string goalName, string description, int pointAmount, bool goalCompletion) : 
    base (goalName, description, pointAmount)
    {
        _complete = goalCompletion;
    }

    public override string ToString()
    {
        return string.Format ("[{0}] {1} ({2})", ( (_complete == false) ? " " : "x"), GetGoalName(), GetGoalDescription());
    }
    public override string RecordToCSV()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, GetGoalName(), GetGoalDescription(), GetPointAmount(), _complete);
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congradulations! You got {0} more points", GetPointAmount()));
        _complete = true;
    }


}