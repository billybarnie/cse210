class Switch
{

    public Switch() {}

    Menu menus = new Menu();

    public void DownPaymentSwitch()
    {
        int downPaymentMenu = menus.DisplayDownPaymentMenu();

            switch(downPaymentMenu)
            {
                case 1:
                    Console.WriteLine("You");
                    break;
                case 2:
                    Console.WriteLine("are");
                    break;
                case 3:
                    Console.WriteLine("a");
                    break;
                case 4:
                    Console.WriteLine("meanie");
                    break;
            }
    }

}