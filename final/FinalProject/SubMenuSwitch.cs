class SubMenuSwitch
{
    private int downPayment = 0;
    private int tradeIn = 0;
    private DownPayment     downInfo = new DownPayment();
    private TradeIn         tradeInfo = new TradeIn();
    
    Loan                    test = new Loan();
    Menu menus = new Menu();

    public void DownPaymentSwitch()
    {
        while (downPayment != 5)
        {
            downPayment = menus.DisplayDownPaymentMenu();

            switch(downPayment)
            {
                case 1:
                    downInfo.PersonalInformation();
                    break;
                case 2:
                    Console.WriteLine("are");
                    break;
                case 3:
                    Console.WriteLine("a");
                    break;
                case 4:
                    tradeInfo.GetCreditScore();
                    test.APRInfo();
                    break;
            }
        }

        downPayment = 0;
    }

    public void TradeInSubMenu()
    {
        while (tradeIn != 5)
        {
            tradeIn = menus.DisplayTradeInMenu();

            switch (tradeIn)
            {
                case 1:
                    tradeInfo.PersonalInformation();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("one");
                    break;
                case 3:
                    Console.WriteLine("was");
                    break;
                case 4:
                    Console.WriteLine("annoying");
                    break;
            }
        }

        tradeIn = 0;
    }

}