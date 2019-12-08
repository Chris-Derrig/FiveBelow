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
            int quantity = 0;
            string itemQuantity;
            bool mainRepeat = true;
            bool repeat1 = true;
            bool repeat2 = true;

            Console.WriteLine("Welcome to the Five Below shop!");
            Console.WriteLine("Here is a menu that you can select from.");

            //display list
            Product.DisplayItemList(HardList.GetProductList());
            string item;

            while (mainRepeat)
            {
                Console.WriteLine("Please type in the letter of the product you would like to add.");
                item = Console.ReadLine();
                //user selects item
                //Product item is added to receipt
                Product.AddToReceipt(item, HardList.GetProductList());
                
                //user selects quantity of the item
                do
                {
                    Console.WriteLine("Please add the quantity of the item chosen.");
                    itemQuantity = Console.ReadLine();
                    int i = 0;
                    int.TryParse(itemQuantity, out i);
                    if (!int.TryParse(itemQuantity, out i))
                    {
                        Console.WriteLine("Try Again");
                    }
                    else 
                    {
                        
                        repeat1 = false;
                    }
                } while (repeat1);

                Console.WriteLine(Product.ShowObject(item, HardList.GetReceiptList()) + " has been added to the list");
                Console.WriteLine("Would you like do add another item");
                //user chooses to add more items or continue to math methods
                do
                {
                    string doAgain = Console.ReadLine();
                    if (doAgain == "n" || doAgain == "N")
                    {
                        repeat2 = false;
                        mainRepeat = false;
                        
                    }
                    else if (doAgain == "y" || doAgain == "Y")
                    {
                        repeat2 = false;
                        mainRepeat = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 'Y' or 'N'");
                        repeat2 = true;
                    }
                } while (repeat2);
                
            }

            //gives line total (item price * quantity)
            //double total = Compute.LineTotal(total, quantity);
            //double total = Product.DisplayLineItem(item, quantity, HardList.GetReceiptList());
            //HardList.receiptList.ForEach(i => Console.WriteLine("Line Total     " + Compute.LineTotal(Product.SetPrice(item, HardList.receiptList), quantity)));


            ////gives subtotal (Sum of all LineTotals)
            //double lineTotal = Compute.LineTotal(total, quantity);
            //Console.WriteLine("Subtotal       " + Compute.Subtotal(lineTotal));

            ////taxtotal
            //double taxTotal = Compute.Taxtotal(lineTotal);
            //Console.WriteLine("Tax            " + Compute.Taxtotal(lineTotal));

            ////grandtotal
            //Console.WriteLine("Total          " + Compute.Grandtotal(lineTotal, taxTotal));

            ////Validate Payment method
          
            Payment.Money();
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