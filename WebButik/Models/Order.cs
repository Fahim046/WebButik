using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }
        public List<CartRow> Cartrows { get; set; }
        public List<OrderRow> Orderrows { get; set; }


    }
}