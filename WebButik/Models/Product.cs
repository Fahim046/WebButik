﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //[Required]
        //[MaxLength(100)]
        //public string ProductPrice { get; set; }



    }
}