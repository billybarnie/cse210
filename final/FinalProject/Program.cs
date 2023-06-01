using System;

class Program
{
    static void Main(string[] args)
    {
        Menu               menus = new Menu();
        SubMenuSwitch      switches = new SubMenuSwitch();
        int                option = 0;

        Console.WriteLine("Hello, and welcome to Kia Auto where we work with and distribute al Kia Models.");
        Console.WriteLine("How may we assist you today?");
        Console.WriteLine();
        
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




/*
    So far I have created the menus class and the switch class
    this is responsible for getting whether they are doing a 
    trade in or a down payment, I have not put all the methods 
    that need to be called yet inside the switch statement as 
    I am trying to work my way up to doing so. But the information 
    base class is responsible for getting all private information 
    then there is the TradInInfo class and DownPaymentInfo class 
    that is responible for saving specifically the information 
    and the type of transaction they are making which is either 
    trading something in or putting a down payment on the vehicle.
    Then there is the APRInfo class that will be getting things like
    annual income and letter be getting information from the 
    AllVehicles class which that class will be getting a vehicle 
    that is ownned by the dealership, getting the cost and then 
    calculcating the APR the interest and then the payments over the 
    normal transaction process term of 72 months aka 6 years.
    But I have not gotten to the calculations yet however those 
    will be made soon. I thank you for your patience in reading this
    and all of my code.
*/