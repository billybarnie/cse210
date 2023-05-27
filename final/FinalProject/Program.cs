using System;

class Program
{
    static void Main(string[] args)
    {
        Menu               menus = new Menu();
        SubMenuSwitch      switches = new SubMenuSwitch();
        int                option = 0;


        while (option != 3)
        {
            option = menus.DisplayMainMenu();

            switch(option)
            {
                case 1:
                    Console.Clear();
                    switches.DownPaymentSwitch();
                    break;
                case 2:
                    switches.TradeInSubMenu();
                    break;
            }
        }
    }
}