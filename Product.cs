using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace FiveBelowShop
{
    class Product
    {
        //private fields to hold our objects
        private string productCategory;
        private string productName;
        private double productPrice;
        private int productQuantity;

        //public properties to allow access to private fields
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

        //constructors to build Product objects

        public Product()
        {

        }
        public Product(string productName, string productCategory, double productPrice, int productQuantity)
        {
            Name = productName;
            Category = productCategory;
            Price = productPrice;
            Quantity = productQuantity;
        }

        //method to print to the CSV.
        public void ProductToList(List<Product> productList)
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\ProductInventoryDB.txt");

            foreach (Product product in productList)
            {
                string csv = $"{product.Category},{product.Name},{product.Price},{product.Quantity}";
                sw.WriteLine(csv);
            }
            sw.Close();
        }

        public void InputToReceipt(List<Product> receiptList)
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\Receipt.txt");

            foreach (Product product in receiptList)
            {
                string csv = $"{product.Name},{product.Price},{product.Quantity}";
                sw.WriteLine(csv);
            }
            sw.Close();
        }
        public static void AddToReceipt(string s, List<Product> P)
        {
            foreach (Product prod in P)
            {
                
                //compare to list
                if (s == prod.Name)

                {
                    Console.WriteLine($"{prod.Name}, {prod.Price}, {prod.Quantity}, {prod.Category}");
                }
            }
        }

        //method to return Receipt Object
        //public List<Product> CSVToReceipt()
        //{
        //    List<Product> tempProductList = new List<Product>();
        //    List<string> receipt = new List<string>();

        //    StreamReader sr = new StreamReader(@"..\..\..\Receipt.txt");
        //    string line = sr.ReadLine();

        //    while (line != null)
        //    {
        //        receipt.Add(line);
        //        line = sr.ReadLine();
        //    }

        //    foreach (string csv in receipt)
        //    {
        //        string[] csvArray = csv.Split(',');
        //        tempProductList.Add(new Product(csvArray[0], csvArray[1], double.Parse(csvArray[2]), int.Parse(csvArray[3])));

        //    }
        //    return tempProductList;
    }
}
