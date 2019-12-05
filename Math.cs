using System;
using System.Collections.Generic;
using System.Text;

namespace FiveBelowShop
{
    class Math 
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
        public static double Subtotal(string userRepeat, double linevalue)
        {
            if (userRepeat == "y")
            {
               double subtotal =  linevalue += linevalue;
                return subtotal;

            }
            else
            {
               double subtotal = linevalue;
                return subtotal;
            }
        }
        public static double Taxtotal(string userRepeat, double linetax)
        {
            if (userRepeat == "y")
            { 
                double taxtotal = linetax += linetax;
                return taxtotal;

            }
            else
            {
                double taxtotal = linetax;
                return taxtotal;
            }
        }
        public static double Grandtotal(double subtotal, double linetax)
        {
            double grandTotal = subtotal + linetax;
            return grandTotal;
        }
    }
}
