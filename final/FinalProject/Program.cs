using System;

class Program
{
    static void Main(string[] args)
    {
        Menu        menus = new Menu();
        Switch      switches = new Switch();
        int         option = 0;


        while (option != 3)
        {
            option =                menus.DisplayMainMenu();
            int downPaymentMenu =   menus.DisplayDownPaymentMenu();
            int tradeInMenu =       menus.DisplayTradeInMenu();

            switch(option)
            {
                case 1:
                   switches.DownPaymentSwitch();
                   break;
                case 2:
                    while(tradeInMenu != 6)

                        switch(tradeInMenu)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                        }
                        break;
            }
        }
    }
}