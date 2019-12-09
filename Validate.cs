using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FiveBelowShop
{
    class Validate
    {

        public static string startAnother(string anotherOrder)
        {
            while (true)
            {
                if (anotherOrder.ToLower() == "y") 
                {
                    return anotherOrder.ToLower();
                }
                else if (anotherOrder.ToLower() == "n")
                {
                    return anotherOrder.ToLower();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter (y or n)");
                    anotherOrder = Console.ReadLine();
                }

            }
        }

        public static int itemQuantity(string itemQuantity)
        {
            while (true)
            {
                try
                {
                    int quantity = int.Parse(itemQuantity);
                    return quantity;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    itemQuantity = Console.ReadLine();
                }

            }
        }

        public static string itemLetter(string item)
        {
            while (true)
            {
                try
                {
                    if (Regex.IsMatch(item, @"^[A-R|a-r]{1}$"))
                    {
                        return item;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a letter A-R");
                        item = Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a letter A-R.");
                    item = Console.ReadLine();
                }
            }
        }
    }
}
