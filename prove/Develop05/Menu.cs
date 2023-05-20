
class Menu
{
    private List<string> mainMenu, goalMenu;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "",
            "Menu Options: ",
            "",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit",
            ""
       };

       goalMenu = new List<string>
       {
            "The types of goals are:",
            "",
            "1. Simple Goal",
            "2. Checklist Goal",
            "3. Eternal Goal",
            ""
       };

    }
    public int DisplayGetMenu()
    {
        foreach (string menuOption in mainMenu)
        {
            Console.WriteLine(menuOption);
        }
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayGetGoalMenu()
    {
        foreach (string goalType in goalMenu)
        {
            Console.WriteLine(goalType);
        }
        Console.Write("Select a type of goal to create: ");
        return int.Parse(Console.ReadLine());
    }
}