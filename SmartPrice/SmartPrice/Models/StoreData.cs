using System.Collections.Generic;

namespace SmartPrice.Models
{
    public class StoreData
    {
        public string Sku { get; set; }

        public string ProductUrl { get; set; }

        public IEnumerable<Offer> AllOffers { get; set; }
    }
}