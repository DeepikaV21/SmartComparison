﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartPrice.Models
{
    public class Products
    {
        public string ProductName { get; set; }

        public string ProductImage { get; set; }
        public string ProductID { get; set; }

        public string ProductPrice { get; set; }

        public List<StoreData> ProductOffer { get; set; }
    }
}