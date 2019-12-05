using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace FiveBelowShop
{
    class Terminal
    {
        public static void StartTerminal()
        {
            int lineTotal = 3;
            string item;
            int itemQuantity;
            string paymentOption;
            bool userRepeat;
            string addItem;

            Console.WriteLine("Hey there, Welcome to Five Below!");

            Console.WriteLine("Here is a menu of what we have in store today, please select your item by typing in the letter!");
            //display list

            //userselects item
            item = Console.ReadLine();
            validateItem(item);

            Console.WriteLine("Please select the quantity of the item");
            itemQuantity = Console.ReadLine();
            validateQuantity(itemQuantity);

            //call math method
            Console.WriteLine("Your total is: " + lineTotal);

            Console.WriteLine("Would you like to continue shopping?");
            addItem = Console.ReadLine();
            validateContinue(addItem);


            //if yes display menu if no take them to check out
            //repeat

            Console.WriteLine("Your current total is " + lineTotal + " how will you be paying today, cash, card or check?");
            paymentOption = Console.ReadLine();
            paymentForm(paymentOption);
            //regex comes in

            Console.WriteLine("Your order has been processed! Would you like to place another order? (y/n)");
            //validate

        }



        public static void validateItem(string item)
        {
            if (Regex.IsMatch(item, @"^[A-Z]+[a-z]"))
            {
                Console.WriteLine("You selected a valid item");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
                //if (item.ToLower() == "a")
                //{
                //    Console.WriteLine("You selected blank");
                //}
                //else
                //{
                //    Console.WriteLine("That is an invalid input.");
                //}
            }
        }

        public static void validateQuantity(int itemQuantity)
        {
            if (itemQuantity == 1)
            {
                Console.WriteLine("You selected blank");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
        }

        public static void validateContinue(bool userRepeat, string item, string addItem)
        {
            //if (userRepeat == "Y")
            //{
            //    Console.WriteLine("You selected blank");
            //}
            //else
            //{
            //    Console.WriteLine("That is an invalid input.");
            //}
            if (addItem.ToLower = "y")
            {

            }
            do
            {
                item = Console.ReadLine();
            }
            while (userRepeat = true);


        }

        public static void paymentForm(string paymentOption)
        {
            if (paymentOption == "Y")
            {
                Console.WriteLine("You selected blank");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
        }

        //need method to start over with clean reciept



        //public static string displayItemList()
        //{
        //    //first point the StreamReader object at the text file that holds the current inventory in CSV format

        //    foreach (Product product in productList)
        //    {
        //        Console.WriteLine(List<Product>);
        //    }

        //}
        //we display the menu
        //public static void displayItemList(List<Product> p)
        //{
        //    return item1;
        //}
        //    foreach (Product prod in p)
        //    {
        //        Console.WriteLine($"{prod.Category,-15} { prod.Name,-35} { prod.Price,-10} ");

    }
}

