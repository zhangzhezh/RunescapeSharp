using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icon_large")]
        public string IconLarge { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeIcon")]
        public string TypeIcon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("current")]
        public PriceTrend Current { get; set; }

        [JsonProperty("today")]
        public PriceTrend Today { get; set; }

        [JsonProperty("day30")]
        public PriceChange Day30 { get; set; }

        [JsonProperty("day90")]
        public PriceChange Day90 { get; set; }

        [JsonProperty("day180")]
        public PriceChange Day180 { get; set; }

        [JsonProperty("members")]
        public bool MembersOnly { get; set; }
    }
}
