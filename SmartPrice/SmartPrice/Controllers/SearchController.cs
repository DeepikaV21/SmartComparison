using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Semantics3;
using SmartPrice.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SmartPrice.Controllers
{
    public class SearchController : Controller
    {
        private Constants constant = new Constants();


        // GET: Search
        public ActionResult Index()
        {
            var products = new Semantics3.Products("SEM3147C30F97A28FACC3A1EBFB81A68ACC1", "Njc2OGVhZGI2Y2EwYzNjYjFjZDEyYzBjZTRjMGRiMTE");
            products.products_field("search", "iphone");
            var rawProducts = products.get_products();



            if ((int)rawProducts["results_count"] > 0)
            {
                JArray searchProducts = (JArray)rawProducts["results"];

                // For each product in the results
                for (int i = 0; i < searchProducts.Count; i++)
                {
                    String productName = (String)searchProducts[i]["name"];
                    string productImage = string.Empty;

                    if (searchProducts[i]["images"].Count() > 0)
                    {
                        productImage = (String)searchProducts[i]["images"][0];
                    }

                    // Pricing Information
                    JArray ecommerceStores = (JArray)searchProducts[i]["sitedetails"];
                    for (int k = 0; k < ecommerceStores.Count; k++)
                    {
                        String skuInStore = (String)ecommerceStores[k]["sku"];
                        String productUrlInStore = (String)ecommerceStores[k]["url"];

                        // Latest offers from the stores
                        for (int s = 0; s < ((JArray)ecommerceStores[k]["latestoffers"]).Count; s++)
                        {
                            String sellerName = (String)ecommerceStores[k]["latestoffers"][s]["seller"];
                            String price = (String)ecommerceStores[k]["latestoffers"][s]["price"];
                            String currency = (String)ecommerceStores[k]["latestoffers"][s]["currency"];
                            String availability = (String)ecommerceStores[k]["latestoffers"][s]["availability"];
                        }
                    }


                }
            }

                    return View();
            
        }
    }
}