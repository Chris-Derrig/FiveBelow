using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace FiveBelowShop
{
    class Terminal
    {
        #region Terminal Methods
        public static void StartTerminal()
        {
            string item;
            int itemQuantity;

            Console.WriteLine("Welcome to the Five Below shop!");
            Console.WriteLine("Here is a menu that you can select from. Please type in the letter of the product you would like to add.");

            //display list
            Product.DisplayItemList(HardList.GetProductList());

            //user selects item
            item = Console.ReadLine();
            Product.AddToReceipt(item, HardList.GetProductList());

            //user selects quantity of the item
            Console.WriteLine("Please add the quantity of the item chosen.");
            itemQuantity = Convert.ToInt32(Console.ReadLine());

            //
            double total = HardList.receiptList.Sum(Product => Product.Price);
            Console.WriteLine(Math.LineTotal(total, itemQuantity));

        }
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
#endregion