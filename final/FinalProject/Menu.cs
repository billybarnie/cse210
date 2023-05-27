
class Menu
{
    private List<string> mainMenu, tradeInMenu, downPaymentMenu;

    private DownPayment downInfo = new DownPayment();
    public Menu()

    {
        mainMenu = new List<string>
        {
            "",
            "Payment Options: ",
            "",
            "1. Down Payment",
            "2. Trade In",
            "3. Quit",
            ""
       };

       tradeInMenu = new List<string>
       {
            "Complete requirements 1 - 4: ",
            "",
            "1. Personal Information",
            "2. Car model and Year being traded",
            "3. Car model and Year desired",
            "4. Credit Score",
            "5. Quit",
            ""
       };

        downPaymentMenu = new List<string>
        {
            "Complete options 1-4:",
            "",
            "1. Personal Information",
            "2. Intial Down Payment",
            "3. Car model and Year desired",
            "4. Credit Score",
            "5. Quit",
            ""
        };

    }

    public int DisplayMainMenu()
    {
        foreach (string menuOption in mainMenu)
        {
            Console.WriteLine(menuOption);
        }
        Console.Write("Select option desired: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayTradeInMenu()
    {
        Console.Clear();
        foreach (string menuRequirement in tradeInMenu)
        {
            Console.WriteLine(menuRequirement);
        }
        Console.Write("Please select each requirement chronologically: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayDownPaymentMenu()
    {
        Console.Clear();
        foreach (string menuRequirement in downPaymentMenu)
        {
            Console.WriteLine(menuRequirement);
        }
        Console.Write("Please select each requirement chronologically: ");
        return int.Parse(Console.ReadLine());
    }
}

