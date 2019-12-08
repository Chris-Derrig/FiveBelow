using System;
using System.Collections.Generic;
using System.Text;

namespace FiveBelowShop
{
    class Compute
    {
        public static double LineTotal(double x, int itemQuantity)
        {
            double linevalue = x * itemQuantity;
            return linevalue;
        }

        public static double TaxedAmount(double linevalue)
        {
            double linetax = linevalue * .06;
            return linetax;
        }
        public static double Subtotal(double linevalue)
        {
            double subtotal = linevalue++;
            return subtotal;
        }
        public static double Taxtotal(double linetax)
        {

            double taxtotal = linetax * .06;
            return taxtotal;

        }
        public static double Grandtotal(double subtotal, double linetax)
        {
            double grandTotal = subtotal + linetax;
            return grandTotal;
        }
        public static double ChangeDue(double grandTotal, double cash)
        {

            Console.WriteLine(Convert.ToDouble(cash));
            double changedue = grandTotal - cash;
            return changedue;

        }
    }
}
