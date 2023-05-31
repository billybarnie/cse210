class SubMenuSwitch
{
    private int downPayment = 0;
    private int tradeIn = 0;
    private DownPayment         downInfo  = new DownPayment();
    private TradeInInfo         tradeInfo = new TradeInInfo();
    
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
                    Console.Clear();
                    break;
                case 2:
                    downInfo.DisplayGetDownPayment();
                    break;
                case 3:
                    downInfo.DisplayGetModelYear();
                    downInfo.DisplayMonthlyCost();
                    break;
                case 4:
                    test.APRInfo();
                    downInfo.SaveToCSV();
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
                    tradeInfo.TradeInVehicle();
                    break;
                case 3:
                    tradeInfo.DisplayGetModelYear();
                    tradeInfo.DisplayMonthlyCost();
                    
                    break;
                case 4:
                    test.APRInfo();
                    tradeInfo.SaveToCSV();
                    break;
            }
        }

        tradeIn = 0;
    }

}