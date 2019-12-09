using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Linq;

namespace FiveBelowShop
{
    class Product
    {
        #region Private Fields

        private string productLetter;
        private string productCategory;
        private string productName;
        private string productDescription;
        private double productPrice;
        private int productQuantity;

        #endregion

        #region Properties

        //public properties to allow access to private fields
        public string Letter
        {
            get { return productLetter; }
            set { productLetter = value; }
        }
        public string Category
        {
            get { return productCategory; }
            set { productCategory = value; }
        }
        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }
        public double Price
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int Quantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        public string Description
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        #endregion

        #region Constructors
        //constructors to build Product objects
        public Product()
        {

        }
        public Product(string productLetter, string productName, string productCategory, double productPrice, int productQuantity, string productDescription)
        {
            Letter = productLetter;
            Name = productName;
            Category = productCategory;
            Price = productPrice;
            Quantity = productQuantity;
            Description = productDescription;
        }
        #endregion

        #region Product Methods

        public static List<Product> AddToReceipt(string s, int t, List<Product> P)
        {
            //Product prod = new Product();

            foreach (Product prod in P.ToList())
            {
                //compare to list
                if (s.ToLower() == prod.Letter.ToLower())
                {
                    Console.WriteLine($"{prod.Name} @ {prod.Price} each -- {prod.Description}");
                    HardList.GetReceiptList().Add(prod);
                }
            }
                return HardList.GetReceiptList();
        }
        public static double SetPrice(string s, List<Product> P)
        {
            double x = 0;
            foreach (Product prod in P)
            {
                if (s.ToLower() == prod.Letter.ToLower())
                {
                    x = prod.Price;
                }
            }
            return Math.Round((x), 2);
        }
        public static int ReturnQuantity(string s)
        {
            int i;
            int.TryParse(s, out i);
            return i;
        }
        public static void DisplayItemList(List<Product> P)
        {
            foreach (Product prod in P)
            {
                Console.WriteLine($"{prod.Letter,-2} | {prod.Category,-12} | { prod.Name,-35} | { prod.Price,-10} ");
            }
        }
        public static string ShowObject(string s, List<Product> P)
        {
            string n = "";
            foreach (Product prod in P)
            {
                if (s.ToLower() == prod.Letter.ToLower())
                {
                    n = prod.Name;
                }
            }
            return n;
        }

        #endregion
    }
}
