using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }

        [Required]
        public string ProductType { get; set; }
        
        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductSize { get; set; }


        //public List<CartRow> Cartrows { get; set; }
        //public List<OrderRow> Orderrows { get; set; }




    }
}