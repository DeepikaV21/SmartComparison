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
                _apiKey = "SEM3147C30F97A28FACC3A1EBFB81A68ACC1";//ConfigurationManager.AppSettings.Get("APIKey");
            }

        }

        public string APISecret
        {
            get { return _apiSecret; }
            set
            {
                _apiSecret = "Njc2OGVhZGI2Y2EwYzNjYjFjZDEyYzBjZTRjMGRiMTE"; //ConfigurationManager.AppSettings.Get("APISecret");
            }

        }
    }
}