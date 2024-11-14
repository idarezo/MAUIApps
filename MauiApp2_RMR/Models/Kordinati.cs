using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2_RMR.Models
{
    internal class Kordinati
    {
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public string lattitude { get; set; }

        [JsonProperty("lng", NullValueHandling = NullValueHandling.Ignore)]
        public string longitude { get; set; }

        public Kordinati(string lat, string lng)
        {
            this.lattitude = lat;
            this.longitude = lng;
        }
    }
}
