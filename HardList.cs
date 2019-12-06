using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FiveBelowShop
{
    class HardList
    {
        private static List<Product> productList = new List<Product>()
            {
                { new Product ("A", "Bettermade Potato Chips","Food", 3.49, 10, "Best Chips Ever") },
                { new Product ("B", "Detroit Style Coney Dog","Food", 1.59, 10, "Great Eats") },
                { new Product ("C","Sander's Hot Fudge Cream Puff","Food", 4.09, 10, "Very Cold") },
                { new Product ("D","Greek Salad w/ Chicken","Food", 4.99, 10, "Healthy food") },
                { new Product ("E","Slice of Detroit Style Deep Dish","Food", 3.99, 10, "Really Greasy") },
                { new Product ("F","Minesweeper Game", "Toys", .99, 10, "Designed for you to lose") },
                { new Product ("G","Star Wars Lego MiniFiguers Set", "Toys", 3.99, 10, "Join the Dark Side") },
                { new Product ("H","Stuffed Animal (Unicorn)", "Toys", 4.49, 10, "Cheaply made") },
                { new Product ("I","Uno Card Game", "Toys", 3.49, 10, "Guarnteed to Start Fights") },
                { new Product ("J","Ball In Cup", "Toys", 1.99, 10, "Overpriced") },
                { new Product ("K","Vernors Soda","Beverages", .99, 10, "Just a few Years old- Totally fine") },
                { new Product ("L","Stoh's Detroit Lager","Beverages", .99, 10, "Drink up") },
                { new Product ("M","Boston Cooler","Beverages", 2.49, 10, "Great way to break your new years res") },
                { new Product ("N","1/2 Gallon of Cider","Beverages", 4.99, 10, "add iquor and you have a recipe for a great time") },
                { new Product ("O","Faygo Rock n Rye","Beverages", 1.49, 10, "Buy it") },
                { new Product ("P","Cozy Matching Family Pajamas","Apparel",  2.49, 10, "This is a steal") },
                { new Product ("Q","Fuzzy Slippers","Apparel",  4.29, 10, "Your pet will eat it") },
                { new Product ("R","Graphic Print Infinity Scarf","Apparel",  3.99, 10, "Guaranteed to be lost within a month") }
        };
        public static List<Product> receiptList = productList.Select(receipt => new Product { Name = receipt.Name, Price = receipt.Price, Quantity = receipt.Quantity }).ToList();

        public static List<Product> GetProductList()
        {
            return productList;
        }

        public static List<Product> GetReceiptList()
        { 
            return receiptList;
        }
    }
}
