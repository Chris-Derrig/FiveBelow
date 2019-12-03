using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FiveBelowShop
{
    class Payment
    {
        public static void Money()
        {
            string credit = Console.ReadLine();
            Match temp = Regex.Match(credit, @"([0-9]{16})");

            if ((Regex.IsMatch(credit, @"(^4\d{15}$)")))
            {
                Console.WriteLine("Visa.. Valid Input");
            }
            if ((Regex.IsMatch(credit, @"(^5[1-5]\d{14}$)")))
            {
                Console.WriteLine("Master Card.. Valid Input");

            }
        }
    }
}
