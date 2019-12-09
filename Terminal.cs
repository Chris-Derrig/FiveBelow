using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace FiveBelowShop
{
    class Terminal
    {
        public static void StartTerminal()
        {
            //repeats the terminal
            bool repeatTerminal = true;

            Console.WriteLine("Welcome to the Five Below shop!");
            Console.WriteLine("Here is a menu that you can select from.");

            //display list
            while (repeatTerminal)
            {
                List<Product> productList = new List<Product>();
                List<Product> recieptList = new List<Product>();
                productList.Clear();
                recieptList.Clear();
                productList = HardList.GetProductList();

                int itemQuantity;
                bool mainRepeat = true;
                string item;
                string anotherOrder;

                Product.DisplayItemList(productList);

                while (mainRepeat)
                {
                    //user selects item
                    Console.WriteLine("\nPlease type in the LETTER of the product you would like to add.");
                    item = Validate.itemLetter(Console.ReadLine());

                    //user selects quantity of the item
                    Console.WriteLine("Please add the quantity of the item chosen.");
                    itemQuantity = Validate.itemQuantity(Console.ReadLine());

                    double total = Compute.LineTotal(Product.SetPrice(item, HardList.GetProductList()), itemQuantity);

                    //Product item is added to receipt
                    Product.AddToReceipt(item, itemQuantity, HardList.GetProductList());

                    //notify the customer that item is added to cart and print running total
                    Console.WriteLine(Product.ShowObject(item, HardList.GetReceiptList()) + " has been added to the list\n");
                    Console.WriteLine($"Your current total is " + Compute.Subtotal(total).ToString("C2"));


                    //user chooses to add more items or continue to math methods
                    Console.WriteLine("Would you like to add another item (y or n)?");

                    string doAgain = Validate.startAnother(Console.ReadLine());
                    if (doAgain == "n")
                    {
                        mainRepeat = false;
                    }
                    else if (doAgain == "y")
                    {
                        mainRepeat = true;
                    }
                }
                #region Display the lineitems line totals, subtotal, tax, grandtotal

                Console.WriteLine("\n");
                Console.WriteLine("Five Below Bodega\n");
                var combo = HardList.GetReceiptList().Zip(HardList.quantityList, (a, b) => new { N = a.Name, Price = b });
                foreach (var np in combo)
                {
                    Console.WriteLine(np.N + "......." + np.Price.ToString("C2"));
                }

                //gives subtotal (Sum of all LineTotals)
                Console.WriteLine("Subtotal......................" + Compute.ShowSubtotal().ToString("C2"));

                //gives the tax for the receipt total
                Console.WriteLine("Tax..........................." + Compute.Taxtotal(Compute.ShowSubtotal()).ToString("C2"));

                //gives the grandtotal
                Console.WriteLine("Total........................." + Compute.Grandtotal(Compute.ShowSubtotal(), Compute.TaxedAmount(Compute.ShowSubtotal())).ToString("C2") + "\n");
                #endregion

                ////Validate Payment method
                Payment.Money();

                Console.WriteLine("Would you like to place another order (y or n)?");
                anotherOrder = Validate.startAnother(Console.ReadLine());
                if (anotherOrder == "n")
                {
                    repeatTerminal = false;
                    Console.WriteLine("Thank you for shopping!");
                }
                else if (anotherOrder == "y")
                {
                    repeatTerminal = true;
                }
            }
        }
    }
    
}
