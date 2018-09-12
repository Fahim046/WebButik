using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class Cart
    {
        [Key]
        public int CartId {get;set;}

        //[ForeignKey ("CustomerId")]  // No need to use foreignKey.. It is used to trace back in the relationship diagram.. While to go forward
        //in the diagram the simple relationship (One - One Relationships &  One - Many Relationships) is enough to show. as shown in the following:
        //public int CustomerId { get; set; }

        public List<CartRow> Cartrows { get; set; } // One - Many Realtionship
        //public Customer Customer { get; set; }  // One - One Relationship

    }
}