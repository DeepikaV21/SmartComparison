using System.Collections.Generic;

namespace SmartPrice.Models
{
    public class StoreData
    {
        public string StoreName { get; set; }
        public string Sku { get; set; }

        public string ProductUrl { get; set; }

        public List<Offer> AllOffers { get; set; }
    }
}