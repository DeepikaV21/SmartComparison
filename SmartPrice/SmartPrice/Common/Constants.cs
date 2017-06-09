using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SmartPrice.Common
{
    public class Constants
    {
        private string _apiKey;
        private string _apiSecret;

        public string APIKey
        {
            get { return _apiKey; }
            set
            {
                _apiKey = ConfigurationManager.AppSettings.Get("APIKey");
            }

        }

        public string APISecret
        {
            get { return _apiSecret; }
            set
            {
                _apiSecret = ConfigurationManager.AppSettings.Get("APISecret");
            }

        }
    }
}