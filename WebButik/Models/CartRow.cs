using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class CartRow
    {

        [Key]
        public int CartrowId { get; set; }
        public int Amount { get; set; }

        //[ForeignKey("CartId")] // No need to use foreignKey.. It is used to trace back in the relationship diagram.. While to go forward
        //in the diagram the simple relationship (One - One Relationships &  One - Many Relationships) is enough to show. as shown in the following:
        //public int CartId { get; set; }

        //One - One Relationships
        public Product Product { get; set; }
        //public Cart Cart { get; set; }

    }
}