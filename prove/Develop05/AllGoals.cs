class AllGoals
{
    private List<Goal> _allGoals = new List<Goal>();

    private int _points;

    public int GetPoints()
    {
        return _points;
    }

    public void DisplayPoints()
    {
        Console.WriteLine(string.Format("You have {0} points.", _points));
    }

    public void AddingGoal(Goal _goal)
    {
        _allGoals.Add(_goal);
    }
    
    public void DisplayGoalsList()
    {
        foreach (Goal goal in _allGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void SaveToACSV()
    {
        Console.Clear();
        Console.Write("What would you like to save the filename under? ");
        string user = Console.ReadLine();
        Console.Clear();

        string file = user;

        using (StreamWriter newFile = new StreamWriter(file))
        {
            foreach (Goal goal in _allGoals)
            {
                newFile.WriteLine(goal.RecordToCSV().Trim());
            }
        }
    }

    public void LoadFromACSV()
    {   
        Console.Clear();
        Console.WriteLine();
        Console.Write("What file would you like to load? ");
        string loadFileName = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Warning, this will overwrite any newly entered goals, are you sure you wish to continue? ");
        string warningResponse = Console.ReadLine();
        Console.Clear();

        if (warningResponse == "yes")
        { 
            try 
            {
            string[] goalBlock = System.IO.File.ReadAllLines(loadFileName);
            // Clears any previous goals
            _allGoals.Clear();

            Goal goal = null;

            foreach (string goals in goalBlock)
            {
                

                    string[] goalPart        = goals.Split("|");

                    int goalType             = int.Parse(goalPart[0]);

                    string goalName          = goalPart[1];

                    string goalDescription   = goalPart[2];

                    int goalPoints           = int.Parse(goalPart[3]);

                    int timesComplete        = int.Parse(goalPart[4]);

                    int timesCompleted       = int.Parse(goalPart[5]);

                    int bonus                = int.Parse(goalPart[6]);

                    bool goalCompletion      = bool.Parse(goalPart[7]);

                    switch (goalType)
                    {
                        case 1:
                            goal = new SimpleGoal (goalName, goalDescription, goalPoints, goalCompletion);
                            break;
                        case 2:
                            goal = new ChecklistGoal (goalName, goalDescription, goalPoints, timesComplete, timesCompleted, bonus, goalCompletion);
                            break;
                        case 3:
                            goal = new EternalGoal (goalName, goalDescription, goalPoints);
                            break;

                    }
                    
                    _allGoals.Add(goal);
            }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine();
                Console.Write("ERROR: File Not Found!!");
                Dots();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine();
            Console.Write("Requested file was unable to be loaded");
            Dots();
            Console.Clear();
        }
    }

    public void RecordEvent()
    {   
        Console.Clear();
        Console.WriteLine ("The goals are:");

        foreach (Goal goal in _allGoals)
        {
            Console.WriteLine(string.Format("{0} {1}", _allGoals.IndexOf(goal) + 1, goal.GetGoalName()));
        }

        Console.Write("Which goal did you accomplish? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;

        _allGoals[recordEvent].RecordEvent() ;
        _points += _allGoals[recordEvent].GetPointAmount();

        Console.Clear();
        Console.WriteLine (string.Format ("Congradulations!! You now have {0} points.", _points.ToString()));
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