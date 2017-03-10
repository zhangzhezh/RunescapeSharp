using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class PriceTrend
    {
        [JsonProperty("change")]
        public string Change {get; set; }

        [JsonProperty("price")]
        public string Price {get; set; }
    }
}
