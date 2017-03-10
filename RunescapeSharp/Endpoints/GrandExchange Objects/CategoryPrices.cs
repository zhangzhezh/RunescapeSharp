using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class CategoryPrices
    {
        [JsonProperty("total")]
        public int Total {get; set; }

        [JsonProperty("items")]
        public List<Item> Items {get; set; }
    }
}
