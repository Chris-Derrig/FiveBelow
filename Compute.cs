using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FiveBelowShop
{
    class Compute
    {
        #region Methods to perform receipt math
        public static double LineTotal(double x, int itemQuantity)
        {
            double linevalue = x * itemQuantity;
            HardList.quantityList.Add(linevalue);
            return Math.Round(linevalue,2);
        }
        public static double TaxedAmount(double linevalue)
        {
            double linetax = linevalue * .06;
            return Math.Round(linetax, 2);
        }
        public static double Subtotal(double linevalue)
        {
            double subtotal = HardList.quantityList.Sum();
            return Math.Round(subtotal, 2);
        }
        public static double ShowSubtotal()
        {
            double subtotal = HardList.quantityList.Sum();
            return Math.Round(subtotal, 2);
        }
        public static double Taxtotal(double linetax)
        {

            double taxtotal = linetax * .06;
            return Math.Round(taxtotal, 2);
        }
        public static double Grandtotal(double subtotal, double linetax)
        {
            double grandTotal = subtotal + linetax;
            return Math.Round(grandTotal, 2);
        }
        #endregion
    }
}
