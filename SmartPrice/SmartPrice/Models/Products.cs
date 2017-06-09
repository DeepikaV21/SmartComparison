using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartPrice.Models
{
    public class Products
    {
        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public IEnumerable<StoreData> ProductOffer { get; set; }
    }
}