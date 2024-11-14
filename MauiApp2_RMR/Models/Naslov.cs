using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2_RMR.Models
{
    internal class Naslov
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string naslov { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string city { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string state { get; set; }

        [JsonProperty("stateCode", NullValueHandling = NullValueHandling.Ignore)]
        public string postnaDr { get; set; }


        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string postnaSt { get; set; }

        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Kordinati kordinati { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string drzava { get; set; }




        public Naslov(string adr,string mesto,string state,string stateCode,string postalCode)
        {
            this.naslov = adr;
            this.city = mesto;
            this.state = state; 
            this.postnaDr = stateCode;  
            this.postnaSt = postalCode;
        }
    }
}
