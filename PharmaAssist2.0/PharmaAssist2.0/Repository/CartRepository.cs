using PharmaAssist2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Repository
{
    public class CartRepository:Repository<Cart>
    {
        public List<Cart> ShowCart(int id)
        {
            return this.contex.Carts.Where(x => x.ConsumerId==id).ToList();
        }
    }
}