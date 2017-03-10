using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class Category
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("alpha")]
        public List<CategoryResult> Results { get; set; }
    }
}
