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
                //user selects item
                Console.WriteLine("\nPlease type in the LETTER of the product you would like to add.");
                item = Console.ReadLine();
                
                do
                {
                    //user selects quantity of the item
                    Console.WriteLine("Please add the quantity of the item chosen.");
                    itemQuantity = Console.ReadLine();
                    double total = Compute.LineTotal(Product.SetPrice(item, HardList.GetProductList()), Product.ReturnQuantity(itemQuantity));

                    //Product item is added to receipt
                    Product.AddToReceipt(item, Product.ReturnQuantity(itemQuantity), HardList.GetProductList());

                    //notify the customer that item is added to cart and print running total
                    Console.WriteLine(Product.ShowObject(item, HardList.GetReceiptList()) + " has been added to the list\n");
                    Console.WriteLine($"Your current total is " + Compute.Subtotal(total));
                    repeat1 = false;

                } while (repeat1);

                //user chooses to add more items or continue to math methods
                Console.WriteLine("Would you like do add another item?");

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

            #region Display the lineitems line totals, subtotal, tax, grandtotal

            Console.WriteLine("\n");
            Console.WriteLine("Five Below Bodega\n");
            var combo = HardList.GetReceiptList().Zip(HardList.quantityList, (a, b) => new { N = a.Name, Price = b });
            foreach (var np in combo)
            {
                Console.WriteLine(np.N + "......." + np.Price);
            }

            //gives subtotal (Sum of all LineTotals)
            Console.WriteLine("Subtotal......................$" + Compute.ShowSubtotal());
            
            //gives the tax for the receipt total
            Console.WriteLine("Tax...........................$" + Compute.Taxtotal(Compute.ShowSubtotal()));
            
            //gives the grandtotal
            Console.WriteLine("Total.........................$" + Compute.Grandtotal(Compute.ShowSubtotal(), Compute.TaxedAmount(Compute.ShowSubtotal())) + "\n");
            #endregion
            
            ////Validate Payment method
            Payment.Money();
        }
    }
}