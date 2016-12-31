//Title:   Assignment 1 - Part 1
//Purpose: Allow the user to create their own menu.
//Date:    22/4/2016
//Author:  Kaine Cochrane
//Version: 1.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcochr13_CSC10210_Ass1
{
    class Program : Menu
    {
        static void Main(string[] args)
        {
            //variables for Program class

            //string to determine if program will restart
            string restartString = "yes";

            //while loop will cause the program to loop if the user enters "yes" after being prompted (if they want to restart)
            while (restartString == "yes" || restartString == "y")
            {
                //define Menu
                Menu mainMenu = new Menu();

                //clear all variables
                mainMenu.ClearAll();

                //prompt user to enter header
                Console.WriteLine("This program will allow you to define your own menu with a header and menu items \nFirst, please enter header:");
                mainMenu.DefineHeader(Console.ReadLine());

                //clear console, display second prompt
                Console.Clear();
                Console.WriteLine("Now, please enter the number of menu items (8 or less):");
                mainMenu.MenuItemPrompt();

                //prompt user to enter menu items
                mainMenu.MenuItemEnter();

                //print entire menu to console
                mainMenu.PrintAll();

                //prompt user to select menu item
                Console.WriteLine("\nEnter in the menu item you wish to select.");
                mainMenu.ItemSelect();

                //prompt asking the user if they want to restart, entering anything other than "yes" or "y" will end the program
                //otherwise loop will begin again
                Console.WriteLine("Do you wish to restart?");
                restartString = Console.ReadLine();
            }
        }
    }
}