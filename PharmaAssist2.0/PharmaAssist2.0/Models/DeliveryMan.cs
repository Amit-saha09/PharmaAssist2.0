using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Models
{
    public class DeliveryMan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int? LoginId { get; set; }
        [Required]
        public int? ZoneId { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
       
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
       [Required]
        public string Image { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public HttpPostedFileBase Imagefile { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        
        public virtual Login Login { get; set; }
        public virtual Zone Zone { get; set; }
    }
}