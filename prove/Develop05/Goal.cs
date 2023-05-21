using System;

abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _pointAmount;
    protected int _bonusPoints;
    protected bool _complete;

    protected int _timesToComplete;
    public Goal() {}

    public Goal(string goalName, string description, int pointAmount)
    {
        _goalName       = goalName;
        _description    = description;
        _pointAmount    = pointAmount;
    }

    public void DisplayGetGoalName()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public void DisplayGetGoalDescription()
    {
        Console.WriteLine();
        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();
    }

    public void DisplayGetPointAmount()
    {
        Console.WriteLine();
        Console.Write("What is the amount of points for achieving said goal? ");
        _pointAmount = int.Parse(Console.ReadLine());
    }

    public void GetNumberOfTimes()
    {
        Console.WriteLine();
        Console.Write("What is the number of times you would like to complete this goal? ");
        _timesToComplete = int.Parse(Console.ReadLine());
    }

    public void GetExtraPoints()
    {
        Console.WriteLine();
        Console.Write("How many bonus points would you like for achieving this goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        
    }

    public string GetGoalName() // Goal Name Getter
    {
        return _goalName;
    }

    public string GetGoalDescription()  // Goal description Getter
    {
        return _description;
    }

    public virtual int GetPointAmount() // Goal Point Amount Getter
    {
        return _pointAmount;
    }
    public abstract string RecordToCSV();
    public abstract void RecordEvent();
}