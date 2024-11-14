using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2_RMR.Models
{
    internal class Uporabnik
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }

        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]

        public string ime { get; set; }

        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]

        public string priimek { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public string starost { get; set; }

       // [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        //public Naslov mesto { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string slika { get; set; }

        [JsonProperty("eyeColor", NullValueHandling = NullValueHandling.Ignore)]
        public string barvaOci { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string vloga { get; set; }

        public Uporabnik(string id, string ime, string priimek, string starost, string slika, string barvaOci, string vloga)
        {
            this.id = id;
            this.ime = ime;
            this.priimek = priimek;
            this.starost = starost;
            //this.mesto = mesto;
            this.slika = slika;
            this.barvaOci = barvaOci;
            this.vloga = vloga; 
        }
    }
}
