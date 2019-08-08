﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductOrderApplication.Models
{
    public class CartItem
    {
            [Key]
            public string ItemId { get; set; }
            public string CartId { get; set; }
            public int Quantity { get; set; }
            public System.DateTime DateCreated { get; set; }
            public int ProductId { get; set; }
            public virtual ListOfProducts Product { get; set; }

    }
}