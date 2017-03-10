using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class Runedate
    {
        [JsonProperty("lastConfigUpdateRuneday")]
        public float Date { get; set; }
    }
}
