using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    /// <summary>
    /// Represents a result from a Category search on the Grand Exchange
    /// </summary>
    public class CategoryResult
    {
        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }
    }
}
