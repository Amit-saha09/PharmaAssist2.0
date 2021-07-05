using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        public int Id { get; set; }
        public int? LoginId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int Totalprice { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual Login Login { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}