using System;

class Program
{
    static void Main(string[] args)
    {

        Menu        menus = new Menu();
        int         choice = 0;
        AllGoals    allGoalsClass = new AllGoals();

        while (choice != 6)
        {
            Console.WriteLine();
            allGoalsClass.DisplayPoints();
            choice = menus.DisplayGetMenu();

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    int createNewGoal = menus.DisplayGetGoalMenu();
                    Goal goal = null;
                    switch(createNewGoal)
                    {
                        case 1:
                            goal = new SimpleGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetPointAmount();
                            allGoalsClass.AddingGoal(goal);
                            Console.Clear();
                            break;
                        case 2:
                            goal = new ChecklistGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetPointAmount();
                            goal.GetNumberOfTimes();
                            goal.GetExtraPoints();
                            allGoalsClass.AddingGoal(goal);
                            Console.Clear();
                            break;
                        case 3:
                            goal = new EternalGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetPointAmount();
                            allGoalsClass.AddingGoal(goal);
                            Console.Clear();
                            break;
                    }
                    break;
                case 2:
                    allGoalsClass.DisplayGoalsList();
                    break;
                case 3:
                    allGoalsClass.SaveToACSV();
                    break;
                case 4:
                    allGoalsClass.LoadFromACSV();
                    break;
                case 5:
                    allGoalsClass.RecordEvent();
                    break;
            }

        }

    }
}