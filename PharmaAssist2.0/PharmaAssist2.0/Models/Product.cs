using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ManagerId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Brandname { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public double Power { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}