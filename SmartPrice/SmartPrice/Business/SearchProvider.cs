using Newtonsoft.Json.Linq;
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

        public SearchProvider()
        {
            products = new Semantics3.Products("SEM3147C30F97A28FACC3A1EBFB81A68ACC1", "Njc2OGVhZGI2Y2EwYzNjYjFjZDEyYzBjZTRjMGRiMTE");
        }

        /// <summary>
        /// Gets the search result.
        /// </summary>
        /// <param name="queryString">The query string.</param>
        /// <returns></returns>
        public List<Products> GetSearchResult(string queryString="iphone")
        {
            //create query
            products.products_field("search", queryString);
            var rawProducts = products.get_products();

            List<Products> models = new List<Products>();

            if ((int)rawProducts["results_count"] > 0)
            {
                JArray searchProducts = (JArray)rawProducts["results"];

                // For each product in the results
                for (int i = 0; i < searchProducts.Count; i++)
                {
                    var model = new Products();
                    model.ProductName = (String)searchProducts[i]["name"];
                    model.ProductID = (String)searchProducts[i]["sem3_id"];

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
                            StoreName = (String)ecommerceStores[k]["name"],
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
                        //storeInfo.AllOffers=storeInfo.AllOffers.OrderBy(i => i.Price).ToList();
                        model.ProductOffer.Add(storeInfo);
                        model.ProductPrice = storeInfo.AllOffers.Min(x => x.Price);

                    }

                    models.Add(model);
                }
            }

            return models;
        }


    }
}