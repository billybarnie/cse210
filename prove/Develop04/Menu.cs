class Menu 
{
    private List<string> _menu;

    public Menu()
    {
    }
    public void GetMenu()
    {

        _menu = new List<string>
        {
            "Menu choices:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit"
        };

        foreach (string choice in _menu)
        {
            Console.WriteLine(choice);
        }
    }
}