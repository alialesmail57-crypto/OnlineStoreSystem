using System;
using System.Collections.Generic;
using System.Text;

namespace ShopData.Models
{
    public interface Ipurchasable
    {
        public bool Buy(int quantity);
        public bool Restock(int quantity);


    }
}
