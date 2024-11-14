using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2_RMR.Models
{
    internal class UporabnikiWrapper
    {
        [JsonProperty("users")]
        public List<Uporabnik> Users { get; set; }

        public UporabnikiWrapper(List<Uporabnik> users)
        {
            this.Users = users;
        }
    }
}
