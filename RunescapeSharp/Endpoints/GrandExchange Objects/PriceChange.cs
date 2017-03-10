using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class PriceChange
    {
        [JsonProperty("trend")]
        public string Trend {get; set; }

        [JsonProperty("price")]
        public string Price {get; set; }
    }
}
