using ShopData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopData
{
    public class Data
    {
         public  List<Product> products()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Iphone 15 pro",  StockQuantity = 10,Price = 700.99f, Category = 1 },
                new Product { Id = 2, Name = "Galaxy S26",     StockQuantity = 5, Price = 699.99f, Category = 2 },
                new Product { Id = 3, Name = "Dell XPS 13",    StockQuantity = 8, Price = 599.99f, Category = 1 },
                new Product { Id = 4, Name = "Sony WH-1000XM4",StockQuantity = 0, Price = 400.99f, Category = 3 },
                new Product { Id = 5, Name = "Apple Watch",    StockQuantity = 7, Price = 399.99f, Category = 2 },
                new Product { Id = 6, Name = "iPad Air",       StockQuantity = 2, Price = 510.99f, Category = 1 },
                new Product { Id = 7, Name = "Power Bank",     StockQuantity = 10,Price = 200.99f, Category = 3 },
                new Product { Id = 8, Name = "Laptop",         StockQuantity = 4, Price = 400.99f, Category = 2 },
                new Product { Id = 9, Name = "Galaxy Watch",   StockQuantity = 0, Price = 300.00f, Category = 1 },
                new Product { Id = 10,Name = "Tablet",         StockQuantity = 5, Price = 355.00f, Category = 2 },
            };
            return products;
        }




    }
}
