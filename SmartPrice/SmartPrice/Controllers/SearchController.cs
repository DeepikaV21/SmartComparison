using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Semantics3;
using SmartPrice.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmartPrice.Business;
using SmartPrice.Models;

namespace SmartPrice.Controllers
{
    public class SearchController : Controller
    {
        private Constants constant = new Constants();
        private SearchProvider searchBusiness = new SearchProvider();
        
        // GET: Search
        public ActionResult Index()
        {
            SearchModel model = new SearchModel();
            return View(model);
        }


        public PartialViewResult Search(string query)
        {
            SearchModel searchModel = new SearchModel();

            searchModel.Query = query;
            searchModel.PageNumber = 1;
            var searchResults = searchBusiness.GetSearchResult(query);
            if (searchResults != null)
            {
                searchModel.SearchResults = searchResults;
                return PartialView("index", searchModel);
            }

            return PartialView("index", searchModel);
        }
    }
}