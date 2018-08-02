using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public List<OrderRow> Orderrows { get; set; }


    }
}