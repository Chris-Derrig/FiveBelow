using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BelowFive
{
    class Terminal
    {
        public static void StartTerminal()
        {
            int lineTotal = 3;
            string item1;
            int itemQuantity;
            string userRepeat;

            Console.WriteLine("Hey there, Welcome to Five Below!");
            Console.WriteLine("Here is a menu of what we have in store today, please select your item by typing in the number or letter!");
            //we display the menu
            //user selects the item 
            Console.WriteLine("Please select the quantity of the item");
            //user selects the quantity
            //display the line total
            Console.WriteLine("Your total is: " + lineTotal);
            Console.WriteLine("Would you like to continue shopping?");
            //allow user to choose
            //if yes display menu if no take them to check out
            //repeat
            Console.WriteLine("Your current total is " + lineTotal + " how will you be paying today, cash, card or check?");
            //user selects form of payment
            //regex comes in
            Console.WriteLine("Your order has been processed! Would you like to place another order? (y/n)");
            //validate
        }

        public static string displayItemList(List<Product> productList)
        {
            return;
        }

        public static string AddItem(string item1)
        {
            return 1;
        }

        public static int itemAmount(int itemQuantity)
        {
            return itemQuantity;
        }

        public static double cartAmount(double cartTotal)
        {
            return cartTotal;
        }

        public static string continueShop(string userRepeat)
        {
            //maybe make this a bool
            return userRepeat;
        }

        public static string paymentForm(string paymentOption)
        {
            return paymentOption;
        }

        public static string displayRet(string displayRept)
        {
            return displayRept;
        }

        public static bool paymentAccept(bool paymentTrue)
        {
            return paymentTrue;
        }
    }
}
