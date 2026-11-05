using System;
using System.Collections.Generic;
using System.Text;

namespace ShopData.Models
{
    public class Admin : User
    {
        public override string GetRole()
        {
            throw new NotImplementedException();
        }
    }
}
