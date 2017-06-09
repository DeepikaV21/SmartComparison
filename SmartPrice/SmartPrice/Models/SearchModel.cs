using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartPrice.Models
{
    public class SearchModel
    {
        public string Query { get; set; }

        public int PageNumber { get; set; }

        public List<Products> SearchResults { get; set; }

        public List<Offer> OfferResults { get; set; }
    }
}