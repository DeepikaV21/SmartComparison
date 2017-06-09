using Newtonsoft.Json.Linq;
using Semantics3;
using SmartPrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartPrice.Business
{
    public class SearchProvider
    {
        private Semantics3.Products products;
        private Semantics3.Offers offers;

        public SearchProvider()
        {
            products = new Semantics3.Products("SEM3147C30F97A28FACC3A1EBFB81A68ACC1", "Njc2OGVhZGI2Y2EwYzNjYjFjZDEyYzBjZTRjMGRiMTE");
            offers = new Offers("SEM3147C30F97A28FACC3A1EBFB81A68ACC1", "Njc2OGVhZGI2Y2EwYzNjYjFjZDEyYzBjZTRjMGRiMTE");
        }

        /// <summary>
        /// Gets the search result.
        /// </summary>
        /// <param name="queryString">The query string.</param>
        /// <returns></returns>
        public List<Models.Products> GetSearchResult(string queryString = "iphone")
        {
            //create query
            products.products_field("search", queryString);
            var rawProducts = products.get_products();

            List<Models.Products> models = new List<Models.Products>();

            if ((int)rawProducts["results_count"] > 0)
            {
                JArray searchProducts = (JArray)rawProducts["results"];

                // For each product in the results
                for (int i = 0; i < searchProducts.Count; i++)
                {
                    var model = new Models.Products();
                    model.ProductName = (String)searchProducts[i]["name"];

                    if (searchProducts[i]["images"].Count() > 0)
                    {
                        model.ProductImage = (String)searchProducts[i]["images"][0];
                    }

                    // Pricing Information

                    model.ProductOffer = new List<StoreData>();

                    JArray ecommerceStores = (JArray)searchProducts[i]["sitedetails"];
                    for (int k = 0; k < ecommerceStores.Count; k++)
                    {
                        var storeInfo = new StoreData()
                        {
                            Sku = (String)ecommerceStores[k]["sku"],
                            ProductUrl = (String)ecommerceStores[k]["url"],
                            AllOffers = new List<Offer>()
                        };


                        // Latest offers from the stores
                        for (int s = 0; s < ((JArray)ecommerceStores[k]["latestoffers"]).Count; s++)
                        {
                            var offer = new Offer();
                            offer.Seller = (String)ecommerceStores[k]["latestoffers"][s]["seller"];
                            offer.Price = (String)ecommerceStores[k]["latestoffers"][s]["price"];
                            offer.Currency = (String)ecommerceStores[k]["latestoffers"][s]["currency"];
                            offer.Availaibility = (String)ecommerceStores[k]["latestoffers"][s]["availability"];

                            storeInfo.AllOffers.Add(offer);
                        }

                        model.ProductOffer.Add(storeInfo);
                    }

                    models.Add(model);
                }
            }

            return models;
        }

        public List<Offer> GetOfferResult(string sem3Id = "7JAykYaFyiYscEmcAwYC64")
        {
            offers.offers_field("sem3_id", sem3Id);
            JObject offerResults = offers.get_offers();

            List<Offer> offerList = new List<Offer>();
            if ((int)offerResults["results_count"] > 0)
            {
                JArray offerSite = (JArray)offerResults["results"];

                // For each product in the results
                for (int i = 0; i < offerSite.Count; i++)
                {
                    Offer offer = new Offer();
                    offer.SiteDetails = (String)offerSite[i]["sitedetails_name"];
                    offer.Price = (String)offerSite[i]["price"];
                    offer.Seller = (String)offerSite[i]["seller"];
                    offer.Currency = (String)offerSite[i]["currency"];
                    offer.Availaibility = (String)offerSite[i]["availability"];
                    offerList.Add(offer);
                }
            }
            return offerList;
        }
    }
}