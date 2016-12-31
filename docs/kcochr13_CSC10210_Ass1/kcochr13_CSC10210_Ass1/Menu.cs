using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcochr13_CSC10210_Ass1
{
    class Menu
    { 
        //variables for Menu class

        //define menu header string
        private string headerString;
        //define integers used (primarily for counting amount of menu items determined by user)
        private int itemAmountInt = 0;
        private int itemNumberInt = 1;
        private int countInt = 0;
        //array to hold menu items (as strings)
        private string[] menuItemArray = new string[9];

        //method for defining the header
        public string DefineHeader(string hsString)
        {
            headerString = hsString;
            //if statement for if the user doesn't enter a header (will be set to default value)
            if (hsString == "")
            {
                headerString = "Default Header";
            }
            return headerString;
        }

        //method for when user is prompted to enter number of menu items
        public void MenuItemPrompt()
        {
            //try-catch statement, will prevent the user from crashing the program if they don't enter a number
            try
            {
                //will convert the amount entered to an int, to determine loop in next method
                itemAmountInt = Convert.ToInt16(Console.ReadLine());
            }
            catch(FormatException IllegalFormat)
            {
                Console.WriteLine(IllegalFormat.Message);
            }
        }

        //method prompting user to enter each menu item
        public void MenuItemEnter()
        {
            //try-catch will prevent program from crashing if user entered in >8 menu items, will display error message
            try
            {
                while (countInt < itemAmountInt)
                {
                    Console.WriteLine("Please enter item number {0}", itemNumberInt);
                    menuItemArray[itemNumberInt] = Console.ReadLine();
                    itemNumberInt += 1;
                    countInt++;
                }
            }
            catch (IndexOutOfRangeException RangeException)
            {
                Console.WriteLine(RangeException.Message);
            }
        }

        //method for printing the entire menu to the console
        public void PrintAll()
        {
            //clears console, so only menu will be displayed
            Console.Clear();
            //writes the header
            Console.WriteLine(headerString + "\n");
            countInt = 0;
            //foreach loop with "item" string defined, to write items from array (as a string) to the console
            foreach (string itemString in menuItemArray)
            {
                if (itemString != null)
                {
                    //formatting to show correct numbering before each menu item
                    Console.WriteLine("{0}. {1}", countInt, itemString.ToString());
                }
                else
                {
                    //else intentionally left blank, other error handling will prevent program from crashing
                }
                //increment the count int by one each loop, i.e. 1., 2., 3. etc.
                countInt += 1;
            }
        }

        //method for when the user selects an item from the menu
        public void ItemSelect()
        {
            //try-catch statement will display error message if user attempts to display results from a menu with incorrect/null input
            //afterwards, will prompt restart
            try
            {
                //reads input from user, displays item number corresponding to input
                itemNumberInt = Convert.ToInt16(Console.ReadLine());
                //displays item from array (with formatting)
                Console.WriteLine("You have selected '{0}'.", menuItemArray[itemNumberInt].ToString());
            }
            //exception for if the user input is in an incorrect format
            catch (FormatException)
            {
                Console.WriteLine("Information was incorrectly input.");
            }
            //user-defined exception for if user selects a null entry in the menu, or a number which doesn't correspond to a menu item
            catch (NullReferenceException)
            {
                throw new MenuException("Null reference found");
            }
            //exception for if the user attempts to select a number outside the menu range (1-8)
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        //returns all data to default values and clears the console
        public void ClearAll()
        {
            Console.Clear();
            itemNumberInt = 1;
            countInt = 0;
            itemAmountInt = 0;
            headerString = null;
        }
    }
}