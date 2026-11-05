using System;
using System.Collections.Generic;
using System.Text;

namespace ShopData.Models
{
    public class Customer:User
    {
        public int Id { get; set; }
        public string Name { get; set; }
       List<Product>PurchaseProducts=new List<Product>();

        public override string GetRole()
        {
            throw new NotImplementedException();
        }
    }
}
