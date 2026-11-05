using System;
using System.Collections.Generic;
using System.Text;

namespace ShopData.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract string GetRole();








    }
}
