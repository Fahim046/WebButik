using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        public List<CartRow> Cartrows { get; set; } // One - Many Realtionship
        //public Customer Customer { get; set; }  // One - One Relationship

    }
}