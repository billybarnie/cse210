using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu printMenu = new Menu();
        
        int response = 0;

        while (response != 4)
        {
            printMenu.GetMenu();
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathe = new BreathingActivity("Breathing activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    0);
                    breathe.DisplayBreathing();
                    break;
                case 2:
                    Console.Clear();
                    ReflectingActivity reflect = new ReflectingActivity("Reflecting activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    0);
                    reflect.DisplayReflecting();
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity list = new ListingActivity("Listing activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    0);
                    list.DisplayListing();
                    break;
            }


        }
        /*
            I made my own class for the Menu so that the Program 
            Class wouldn't be so bulky. I also made my own information
            member functions inside of their own respective classes as only
            two classes needed them they are called Inform and GetInformation
            They are designed to take the bulk out of the display activities call
            so that they can run faster and be less bulky. They are separate from 
            the ActivityDisplay which is the common call for all the activities.
        */
        
    }
}