using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartPrice.Models
{
    public class Product
    {
        public string code { get; set; }
        public int offset { get; set; }
        public int results_count { get; set; }
        public List<Result> results { get; set; }
        public int total_results_count { get; set; }
    }

    public class Sitedetail
    {
        public int recentoffers_count { get; set; }
        public List<object> latestoffers { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string sku { get; set; }
        public string listprice_currency { get; set; }
        public string listprice { get; set; }
    }

    public class Result
    {
        public string size { get; set; }
        // public List<object> gtins { get; set; }
        public string sem3_id { get; set; }
        public string color { get; set; }
        public string cat_id { get; set; }
        public string width { get; set; }
        public string length { get; set; }
        public string height { get; set; }
        public string price_currency { get; set; }
        public string variation_id { get; set; }
        public string brand { get; set; }
        public string upc { get; set; }
        public string price { get; set; }
        public string model { get; set; }
        //public int created_at { get; set; }
        public string name { get; set; }
        // public string mpn { get; set; }
        //public List<object> messages { get; set; }
        public List<string> variation_secondaryids { get; set; }
        public List<string> geo { get; set; }
        public string manufacturer { get; set; }
        //public string ean { get; set; }
        // public int updated_at { get; set; }
        public List<string> images { get; set; }
        public string weight { get; set; }
        //  public List<Sitedetail> sitedetails { get; set; }
        public string description { get; set; }
        public Features features { get; set; }
        public int images_total { get; set; }
        public string category { get; set; }
    }
    public class Features
    {
        [JsonProperty("Data Plan Required")]
        public string Plan_Required { get; set; }

        [JsonProperty("Screen Resolution")]
        public string Screen_Resolution { get; set; }

        [JsonProperty("Rear-Facing Camera")]
        public string Rear_Facing_Camera { get; set; }

        [JsonProperty("Unlocked")]
        public string Unlocked { get; set; }

        [JsonProperty("Internal_Memory")]
        public string Internal_Memory { get; set; }

        [JsonProperty("Internal_Connectable")]
        public string Internet_Connectable { get; set; }

        [JsonProperty("Front-Facing Camera")]
        public string Front_Facing_Camera { get; set; }


        //public string __invalid_name__Email Capable { get; set; }

        [JsonProperty("Touch Screen")]
        public string Touch_Screen { get; set; }

        [JsonProperty("Battery Type")]
        public string _Battery_Type { get; set; }
        // public string __invalid_name__Wireless Compatibility { get; set; }

        [JsonProperty("Operating System")]
        public string Operating_System { get; set; }

        // public string __invalid_name__Wireless Technology { get; set; }
        //public string __invalid_name__Bluetooth Enabled { get; set; }
        //public string __invalid_name__Warranty Terms - Parts { get; set; }
        //public string __invalid_name__Integrated Camera { get; set; }
        //public string __invalid_name__Keyboard Type { get; set; }
        //public string __invalid_name__Water Resistant { get; set; }

        [JsonProperty("Screen Size")]
        public string Screen_Size { get; set; }
        // public string __invalid_name__Display Type { get; set; }
        // public string Carrier { get; set; }
        //public string __invalid_name__Processor Brand { get; set; }


        [JsonProperty("Color Category")]
        public string Color_Category { get; set; }

        [JsonProperty("Device Manufacturer")]
        public string Device_Manufacturer { get; set; }
        //  public string blob { get; set; }
        //public string __invalid_name__Built-In GPS { get; set; }
        //public string __invalid_name__No-Contract { get; set; }
        // public string __invalid_name__Phone Style { get; set; }
        //  public string __invalid_name__Stand-By Time { get; set; }
        //public string __invalid_name__Standby Time { get; set; }
        //  public string __invalid_name__Talk Time { get; set; }
        //   public string __invalid_name__Battery Cell Type { get; set; }
        //public string __invalid_name__Assembly Details { get; set; }
        //  public string __invalid_name__Not Included { get; set; }
        //public string Includes { get; set; }
        //public string __invalid_name__Maximum Resolution { get; set; }

        [JsonProperty("Phone_Type")]
        public string Phone_Type { get; set; }
        // public string __invalid_name__Video Resolution { get; set; }
        //public string __invalid_name__Wired Connectivity { get; set; }
        //public string __invalid_name__Service Provider { get; set; }
        public string Megapixels { get; set; }
        public string Display { get; set; }
        public string USB { get; set; }
        public string Messaging { get; set; }
        public string Camera { get; set; }
        //  public string __invalid_name__Front-facing Camera { get; set; }
        public string Browser { get; set; }
        public string GPS { get; set; }
        public string Battery { get; set; }
        public string Standby { get; set; }
        public string Dimensions { get; set; }
        public string Bluetooth { get; set; }
        public string __invalid_name__4G { get; set; }
        public string __invalid_name__3G { get; set; }
        public string __invalid_name__2G { get; set; }
        public string Chipset { get; set; }
        public string Talktime { get; set; }
        //  public string __invalid_name__Phone Cellular Band { get; set; }
        // public string __invalid_name__Color Class { get; set; }
        //public string __invalid_name__Phone Style Type { get; set; }
        // public string __invalid_name__Assembled Product Dimensions(L x W x H) { get; set; }
        //public string __invalid_name__RAM Memory { get; set; }
        //public string __invalid_name__Has Touchscreen { get; set; }
        //  public string __invalid_name__Has Bluetooth { get; set; }
        //public string __invalid_name__Has Flash { get; set; }
        //public string __invalid_name__Display Resolution { get; set; }
        // public string __invalid_name__Display Technology { get; set; }
        // //public string __invalid_name__Backlight Type { get; set; }
        //public string __invalid_name__Cell Phone Service Provider { get; set; }
        //public string __invalid_name__Primary Shelf ID { get; set; 
        [JsonProperty("Battery_Size")]
        public string Battery_Size { get; set; }
        //public string __invalid_name__Assembled Product Weight { get; set; }
        // public string __invalid_name__Processor Speed { get; set; }
        //public string __invalid_name__Digital Zoom { get; set; }
        // public string __invalid_name__Video Streaming Quality { get; set; }

        [JsonProperty("Features")]
        public string Feature { get; set; }
        //  public string __invalid_name__Voice Activated { get; set; }
        //  public string __invalid_name__Phone Memory(RAM) { get; set; }
        //public string __invalid_name__Media Card Slot { get; set; }
        //public string Sensors { get; set; }
        //  public string __invalid_name__Talk time { get; set; }
        //  public string __invalid_name__Processor Type { get; set; }
        //public string __invalid_name__Cell Phone Type { get; set; }
        //public string __invalid_name__Contains Batteries { get; set; }
        //  public string Resolution { get; set; }
        [JsonProperty("Mobile Operating System")]
        public string Mobile_Operating_System { get; set; }

        // public string __invalid_name__Connector Type { get; set; }
        //  public string __invalid_name__Battery Life { get; set; }
        //public string __invalid_name__Number of Megapixels { get; set; }
        //public string __invalid_name__Cellular Network Technology { get; set; }
        //public string __invalid_name__Front-Facing Camera Megapixels { get; set; }
        //  public string __invalid_name__Contained Battery Type { get; set; }
        //public string __invalid_name__Rear-Facing Camera Megapixels { get; set; }
        //  public string __invalid_name__NFC Technology { get; set; }
        //public string __invalid_name__Mobile Hotspot Capability { get; set; }
        // public string __invalid_name__Maximum Usage Time { get; set; }
        //public string __invalid_name__Charging Interface(s) { get; set; }
        //public string __invalid_name__Model Family { get; set; }
        //public string __invalid_name__Interface Type { get; set; }
        //public string __invalid_name__Maximum RAM Supported { get; set; }
        //public string __invalid_name__Is Portable { get; set; }
        //public string Condition { get; set; }
        //public string __invalid_name__Video Game Platform { get; set; }
        //public string __invalid_name__Standby time { get; set; }
        //public string WLAN { get; set; }
    }

}
