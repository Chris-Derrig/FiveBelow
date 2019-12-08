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

        //private fields to hold our objects

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
        //method to print to the CSV.

        public static void ProductToList(List<Product> productList)
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\ProductInventoryDB.txt");

            foreach (Product product in productList)
            {
                string csv = $"{product.Letter},{product.Category},{product.Name},{product.Price},{product.Quantity}, {product.Description}";
                sw.WriteLine(csv);
            }
            sw.Close();
        }
        public static void InputToReceipt(List<Product> receiptList)
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\Receipt.txt");

            foreach (Product product in receiptList)
            {
                string csv = $"{product.Letter}{product.Name},{product.Price},{product.Quantity}, {product.Description}";
                sw.WriteLine(csv);
            }
            sw.Close();
        }
        public static List<Product> AddToReceipt(string s, List<Product> P)
        {
            //Product prod = new Product();

            foreach (Product prod in P.ToList())
            {
                //compare to list
                if (s.ToLower() == prod.Letter.ToLower())
                {
                    Console.WriteLine($"{prod.Letter}, {prod.Name}, {prod.Price}, {prod.Quantity}, {prod.Category}, {prod.Description}");
                    HardList.receiptList.Add(prod);
                }
            }
                return HardList.receiptList;
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

        //public static void GetCurrentReceipt()
        //{
        //    List<Product> receiptList = HardList.GetProductList().Select(receipt => new Product { Name = receipt.Name, Price = receipt.Price, Quantity = receipt.Quantity }).ToList();

        //    StreamReader sr = new StreamReader(@"..\..\..\.Receipt.txt");

        //    string[] csvArray;

        //    string line = sr.ReadLine();

        //    while (line != null)
        //    {
        //        csvArray = line.Split(',');

        //        HardList.GetReceiptList().Add(Product.CSVToReceipt(line));

        //        line = sr.ReadLine();
        //    }
        //    sr.Close();
        //}
        public static Product CSVToReceipt(string line)
        {
            //first we split CSV into a new string array
            string[] csvArray = line.Split(',');
            //then return NewCar object to the caller
            return new Product(csvArray[1], csvArray[2], csvArray[3], double.Parse(csvArray[4]), int.Parse(csvArray[5]), csvArray[6]);
        }
        public static void DisplayItemList(List<Product> P)
        {
            foreach (Product prod in P)
            {
                Console.WriteLine($"{prod.Letter,-2} | {prod.Category,-12} | { prod.Name,-35} | { prod.Price,-10} ");
            }
        }
        public static double DisplayLineItem(string s, int i, List<Product> P)
        {
            double x = 0;
            foreach (Product prod in P)
            {
                if (s.ToLower() == prod.Letter.ToLower())
                {
                    x = (prod.Price * i);
                }
            }
            return x;
        }

        public static void DisplayLineItems(string v, int q)
        {
            

        }

        #endregion

        //method to return Receipt Object
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
    }
}
