using System;
using System.Collections.Generic;
using System.Text;

namespace FiveBelowShop
{
    class Compute
    {
        public static double LineTotal(double x, int itemQuantity)
        {
            double linevalue = Math.Round((x * itemQuantity),MidpointRounding.AwayFromZero);
            return linevalue;
        }

        public static double TaxedAmount(double linevalue)
        {
            double linetax = Math.Round((linevalue * .06), MidpointRounding.AwayFromZero);
            return linetax;
        }
        public static double Subtotal(double linevalue)
        {
            double subtotal = 0;
            subtotal += linevalue;
            return subtotal;
        }
        public static double Taxtotal(double subtotal)
        {
            //or diuble taxtotal += linetax+;
            double taxtotal = Math.Round((subtotal * .06), MidpointRounding.AwayFromZero);
            return taxtotal;

        }
        public static double Grandtotal(double subtotal, double taxtotal)
        {
            double grandTotal = subtotal + taxtotal;
            return grandTotal;
        }
        public static double ChangeDue(double grandTotal, double cash)
        {
            Convert.ToDouble(cash);

            //.WriteLine(Convert.ToDouble(cash));
            double changedue = grandTotal - cash;
            return changedue;

        }
    }
}
