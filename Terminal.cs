using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FiveBelowShop
{
    class Terminal
    {
        #region Terminal Methods
        public static void StartTerminal()
        {
            int lineTotal = 3;
            string item;
            int itemQuantity;
            string userRepeat;
            bool again = true;
            bool repeat = true;

            Console.WriteLine("Hey there, Welcome to Five Below!");
            Console.WriteLine("Here is a menu of what we have in store today, please select your item by typing in the letter!");
            Product.DisplayItemList(HardList.GetProductList());
            Product.ProductToList(HardList.GetProductList());





            //user selects the item 
            while (again)
            {
                item = Console.ReadLine();
                Product.AddToReceipt(item, HardList.GetProductList());
            }

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
            ////user selects the item 
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
        public static void validateItem(string item)
        {
            if (item.ToLower() == "a")
            {
                Console.WriteLine("You selected blank");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
        }
        #endregion
    }
}

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




