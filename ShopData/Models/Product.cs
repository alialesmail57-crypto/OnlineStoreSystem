using System;
using System.Collections.Generic;
using System.Text;

namespace ShopData.Models
{
    public class Product:Ipurchasable 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int StockQuantity { get; set; }
        private float _price;
        public float Price
        {
            get { return _price; }
            set 
            { 
                if(value < 0)
                {
                    Console.WriteLine("Price cannot be negative");
                }
                else
                {
                    _price = value;
                }
            
            }
        }
        public int Category { get; set; }

        public bool Buy(int quantity)
        {
           if(StockQuantity >=quantity&&quantity>0)
            {
                StockQuantity -=quantity;

            return true;
            }
            else
                return false;
        }

        public bool Restock(int quantity)
        {
            if(quantity > 0)
            {
                StockQuantity += quantity;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
