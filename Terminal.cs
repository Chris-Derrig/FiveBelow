using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FiveBelowShop
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
            displayItemList();
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

        //public static string displayItemList()
        //{
        //    //first point the StreamReader object at the text file that holds the current inventory in CSV format

        //    foreach (Product product in productList)
        //    {
        //        Console.WriteLine(List<Product>);
        //    }
    

            ////string array to hold the split CSV row before parsing into necessary Car object
            //string[] csvArray;

            ////string that grabs and holds the first line of the CSV text file
            //string line = sr.ReadLine();

            ////while loop to iterate through the text file of CSV's building inventory List
            //while (line != null)//as long as the first line of the text file is not null then continue with parsing
            //{
            //    //spilt the CSV on the comma's until we have the sparate values indexed in our string array
            //    csvArray = line.Split(',');

            //    //check to see what type of Car object is in each CSV
            //    if (csvArray[0] == "1")//if it starts with a number 1 then it will be a NewCar object
            //    {
            //        //we add a NewCar object passing a CSV string in to our method which returns a new object
            //        currentInventory.Add(NewCar.CSVToCar(line));
            //    }
            //    else
            //    {
            //        //we add a UsedCar object passing a CSV string in to our method which returns a new object
            //        currentInventory.Add(UsedCar.CSVToCar(line));
            //    }

            //    //we advance the CSV text file to the next row of data
            //    line = sr.ReadLine();
            //}

            ////close the text file when done with File I/O operations
            //sr.Close();

        }
        //we display the menu
        public static void displayItemList(List<Product> p)
        {
            return item1;
        }
            foreach (Product prod in p)
            {
                Console.WriteLine($"{prod.Category,-12} | { prod.Name,-35} | { prod.Price,-10} ");
            }
            ////user selects the item 
            //Console.WriteLine("Please select the quantity of the item");
            //    //user selects the quantity
            //    //display the line total
            //    Console.WriteLine("Your total is: " + lineTotal);
            //    Console.WriteLine("Would you like to continue shopping?");
            //    //allow user to choose
            //    //if yes display menu if no take them to check out
            //    //repeat
            //    Console.WriteLine("Your current total is " + lineTotal + " how will you be paying today, cash, card or check?");
            //    //user selects form of payment
            //    //regex comes in
            //    Console.WriteLine("Your order has been processed! Would you like to place another order? (y/n)");
            //    //validate
            //}



            //public static string AddItem(string item1)
            //{
            //    return 1;
            //}

            //public static int itemAmount(int itemQuantity)
            //{
            //    return itemQuantity;
            //}

            //public static double cartAmount(double cartTotal)
            //{
            //    return cartTotal;
            //}

            //public static string continueShop(string userRepeat)
            //{
            //    //maybe make this a bool
            //    return userRepeat;
            //}

            //public static string paymentForm(string paymentOption)
            //{
            //    return paymentOption;
            //}

            //public static string displayRet(string displayRept)
            //{
            //    return displayRept;
            //}

            //public static bool paymentAccept(bool paymentTrue)
            //{
            //    return paymentTrue;
            //}
        }
    }
}

