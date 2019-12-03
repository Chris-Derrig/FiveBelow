using System;
using System.Collections.Generic;
using System.Text;

namespace FiveBelowShop
{
    class Math
    {
        public static double LineTotal(double price, int quanity)
        {
            ///jsjd
            Product productPrice = new Product();
            double x =  productPrice.Price;

            Product productQuantity = new Product();
            int z = productQuantity.Quantity;

            double linevalue = x * z;
            
            //  double taxTotal = Total * .06;
            // double realValue = Total + taxTotal;

            return linevalue;
        }

    }
}
