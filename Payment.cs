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
        //Visa needs a 4 then 15 numbers

        //MasterCard needs a 5 then a #1-5 then 14 numbers

        //Discover Card start with 6011 then 12 numbers

        //American Express start wiht 347 then 12 numbers

        //if "cash" is inputed then it will take you to the Cash() Method
        //if "credit" is inputed then it will take you to the Credit() Method
        //both need to be put to a ToLower, so it does not matter what you input

        {
        Top:
            try
            {
                Console.Write("Are you paying with Cash, Credit, or Check? ");
                string payment = Console.ReadLine();

                if (payment.ToLower() == "credit")
                {
                    Credit();
                }
                if (payment.ToLower() == "cash")
                {
                    Cash();
                }
                else if (payment.ToLower() == "check")
                {
                    Check();
                }
                else
                {
                    Console.WriteLine("Invalid, please type 'Cash', 'Credit' or 'Check'.");
                    //goes back to the top asking how to pay
                    goto Top;
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Top;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Top;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.");
                //goes back to the top asking how to pay
                goto Top;
            }
        }

        public static void Credit()
        {
        //Start: is below the Next:
        Start:
            try
            {
                Console.WriteLine("Please enter your credit card number.");

                string credit = Console.ReadLine();

                if ((Regex.IsMatch(credit, @"(^4\d{15}$)")))
                {
                    Console.WriteLine("Visa Card.. Valid Input");
                    //Next; Jumps down to printing receipt
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
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Start;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Start;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.");
                //goes back to the top asking how to input their card number
                goto Start;
            }

        //if valid input Next; jumps down to here
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
            try
            {

                Console.Write("Please enter the amount of cash you are using: ");
                string cash = Console.ReadLine();
                if ((Regex.IsMatch(cash, @"(^[0-9]{1,3}\.[0-9]{2}$)")))
                {
                    Console.WriteLine("Cash");
                }
                if ((!Regex.IsMatch(cash, @"(^[0-9]{1,3}\.[0-9]{2}$)")))
                {
                    Console.WriteLine("Please try again.");
                    //if invalid input shoots back up to Monay:
                    goto Monay;
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Monay;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Monay;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.");
                //goes back to the top asking how much cash theyre paying with
                goto Monay;
            }
        }
        public static void Check()
        {
        Checkers:
            try
            {
                Console.Write("Please enter the check number: ");
                string cash = Console.ReadLine();
                if ((Regex.IsMatch(cash, @"(^[0-9]{9}$)")))
                {
                    Console.WriteLine("Check");
                }
                if ((!Regex.IsMatch(cash, @"(^[0-9]{9}$)")))
                {
                    Console.WriteLine("Please try again.");
                    //if invalid input shoots back up to Chekers:
                    goto Checkers;
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Checkers;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cannot input nothing.");
                goto Checkers;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.");
                //goes back to the top asking how to input there check number
                goto Checkers;
            }
        }
        #endregion
    }
}

