using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ManagerId { get; set; }

        public int CategoryId { get; set; }

        public string Image { get; set; }

        public string Brandname { get; set; }

        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Totalprice { get; set; }

        public double Power { get; set; }
    }
}