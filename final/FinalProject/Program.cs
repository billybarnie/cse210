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




/*
    This program is called Kia Auto and it is meant to grab 
    all personal information from the user and then grab the 
    car they desired and the year of the car that they desire.
    From there it grabs the kia car from the dictionary and the 
    cost of the car and then whatever they put down on the vehicle is 
    subtracted or if they put a trade in the cost of the vehicle they 
    are trading in is priced by the year and subtracted from the 
    vehicle they desires cost and from there the cost is divided into 
    72 months and returns the cost of the vehicle before insurance.
    Then when you hit the credit you can input your credit score and 
    the cost of insurance each month and the insurance company 
    and how much that they make and and the cost of the vehicle 
    before insurance that was given to them and then they sign their name.
    From there three txt files are created with their personal information
    the vehicle that they chose and all their personal information and 
    their estimated monthly cost before insurance, a file for all their 
    credit info from their credit score to their monthly car payments with the
    insurance on there. If they are denied its because they left something empty on
    their personal information or did not fill it out, or they did not input 
    their credit info at all. then they will get a denied letter for them
    their credit info will not be saved nor will their personal information.
    This is my final program, thank you for testing it.
*/