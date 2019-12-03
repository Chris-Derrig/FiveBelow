using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FiveBelowShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Terminal.StartTerminal();

            List<Product> productList = new List<Product>()
            {
                { new Product ("Bettermade Potato Chips","Food", 3.49, 10) },
                { new Product ("Detroit Style Coney Dog","Food", 1.59, 10) },
                { new Product ("Sander's Hot Fudge Cream Puff","Food", 4.09, 10) },
                { new Product ("Greek Salad w/ Chicken","Food", 4.99, 10) },
                { new Product ("Slice of Detroit Style Deep Dish","Food", 3.99, 10) },
                { new Product ("Minesweeper Game", "Toys", .99, 10) },
                { new Product ("Star Wars Lego MiniFiguers Set", "Toys", 3.99, 10) },
                { new Product ("Stuffed Animal (Unicorn)", "Toys", 4.49, 10) },
                { new Product ("Uno Card Game", "Toys", 3.49, 10) },
                { new Product ("Ball In Cup", "Toys", 1.99, 10) },
                { new Product ("Vernors Soda","Beverages", .99, 10) },
                { new Product ("Stoh's Detroit Lager","Beverages", .99, 10) },
                { new Product ("Boston Cooler","Beverages", 2.49, 10) },
                { new Product ("1/2 Gallon of Cider","Beverages", 4.99, 10) },
                { new Product ("Faygo Rock n Rye","Beverages", 1.49, 10) },
                { new Product ("Cozy Matching Family Pajamas","Apparel",  2.49, 10) },
                { new Product ("Fuzzy Slippers","Apparel",  4.29, 10) },
                { new Product ("Graphic Print Infinity Scarf","Apparel",  3.99, 10) },
                { new Product ("Winter Hat","Apparel",  1.99, 10) },
                { new Product ("Child's Disney Tee Shirt","Apparel",  4.99, 10) },
                { new Product ("Assorted Hair Ties","Accessories", 1.99, 10) },
                { new Product ("Sponge Bob Wrist Watch","Accessories", 3.49, 10) },
                { new Product ("Christmas Socks","Accessories", 2.49, 10) },
                { new Product ("Generic Phone Case","Accessories", 1.49, 10) },
                { new Product ("Pack of Star Wars Stickers","Accessories", 2.99, 10) },
                { new Product ("Desk Lamp","HomeGoods",  4.49, 10) },
                { new Product ("Entry Rug","HomeGoods",  4.99, 10) },
                { new Product ("Inspiration Poster","HomeGoods",  3.99, 10) },
                { new Product ("Pencil Case","HomeGoods",  1.99, 10) },
                { new Product ("Desktop Organizer","HomeGoods",  2.99, 10) },
                { new Product ("Measuring Cups","Kitchen", 2.99, 10) },
                { new Product ("Spatula","Kitchen", .99, 10) },
                { new Product ("Assorted Wisks","Kitchen", 4.99, 10) },
                { new Product ("Mixing Bowls","Kitchen", 3.49, 10) },
                { new Product ("Cupcake Tin","Kitchen", 3.99, 10) },
                { new Product ("Nail Polish","Misc.", .49, 10) },
                { new Product ("Pencil Toppers","Misc.", .99, 10) },
                { new Product ("Shoelaces","Misc.", .79, 10) },
                { new Product ("USB Charger","Misc.", 4.99, 10) },
                { new Product ("Change Purse","Misc.", 1.99, 10) },
            };

            Product product = new Product();
            product.ProductToList(productList);

            Terminal.displayItemList(productList);

            Console.WriteLine("Hello World!");

            List<Product> receiptList = productList.Select(receipt => new Product { Name = receipt.Name, Price = receipt.Price, Quantity = receipt.Quantity }).ToList();
            product.InputToReceipt(receiptList);

            string input = Console.ReadLine();

            Product.AddToReceipt(input, receiptList);
        }
    }
}



