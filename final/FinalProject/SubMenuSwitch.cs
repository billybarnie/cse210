class SubMenuSwitch
{
    private int downPayment = 0;
    private int tradeIn = 0;
    private DownPayment         downInfo  = new DownPayment();
    private TradeInInfo         tradeInfo = new TradeInInfo();
    private Loan                creditInfo = new Loan();
    Menu                        menus = new Menu();

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
                    downInfo.DisplayGetModel();
                    downInfo.DisplayGetYear();
                    downInfo.DisplayMonthlyCost();
                    break;
                case 4:
                    creditInfo.APRInfo();
                    downInfo.SaveToCSV();
                    creditInfo.SaveToCSV();
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
                    tradeInfo.DisplayGetModel();
                    tradeInfo.DisplayGetYear();
                    tradeInfo.DisplayMonthlyCost();
                    break;
                case 4:
                    creditInfo.APRInfo();
                    tradeInfo.SaveToCSV();
                    creditInfo.SaveToCSV();
                    break;
            }
        }

        tradeIn = 0;
    }

}