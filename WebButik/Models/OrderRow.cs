using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class OrderRow
    {

        [Key]
        public int OrderRowId { get; set; }

    }
}