using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FiveBelowShop
{
    class Payment
    {
        #region Payment Methods
        public static void Money()
        {
            Console.Write("Are you paying with Cash or Credit? ");
            string payment = Console.ReadLine();

            if (payment == "credit")
            {
                Credit();
            }
            else if (payment == "cash")
            {
                Cash();
            }
        }

        public static void Credit()
        {
        Start:
            Console.WriteLine("Please enter your credit card number.");

            string credit = Console.ReadLine();

            if ((Regex.IsMatch(credit, @"(^4\d{15}$)")))
            {
                Console.WriteLine("Visa Card.. Valid Input");
                goto Next;
            }
            if ((Regex.IsMatch(credit, @"(^5[1-5]\d{14}$)")))
            {
                Console.WriteLine("Master Card.. Valid Input");
                goto Next;
            }
            if ((Regex.IsMatch(credit, @"(^6(?:011\d\d|5\d{4}|4[4-9]\d{3}|22(?:1(?:2[6-9]|[3-9]\d)|[2-8]\d\d|9(?:[01]\d|2[0-5])))\d{10}$)")))
            {
                Console.WriteLine("Discover Card.. Valid Input");
                goto Next;
            }
            if ((Regex.IsMatch(credit, @"(^3[47]\d{13}$)")))
            {
                Console.WriteLine("American Express.. Valid Input");
                goto Next;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                goto Start;
            }
        Next:
            Console.WriteLine("Please wait.");

            Console.WriteLine("....");
            Console.WriteLine("....");

            Console.WriteLine("No change back.");
            Console.WriteLine("Printing Reciept.");
        }
        public static void Cash()
        {
        Monay:
            Console.Write("Please enter the amount of cash you are using: ");
            string cash = Console.ReadLine();
            if ((Regex.IsMatch(cash, @"(^[0-9]{1,3}\.[0-9]{2}$)")))
            {
                Console.WriteLine("  ");
            }
            if ((!Regex.IsMatch(cash, @"(^[0-9]{1,3}\.[0-9]{2}$)")))
            {
                Console.WriteLine("Please try again.");
                goto Monay;
            }
        }
        #endregion
    }
}
