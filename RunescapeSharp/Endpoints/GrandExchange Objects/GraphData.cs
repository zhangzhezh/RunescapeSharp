using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RunescapeSharp.Endpoints.GrandExchange_Objects
{
    public class GraphData
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonProperty("daily")]
        private Dictionary<string, int> Daily;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [JsonProperty("average")]
        private Dictionary<string, int> Average;

        [JsonIgnore]
        public Dictionary<DateTimeOffset, int> DailyPrices { get; set; }

        [JsonIgnore]
        public Dictionary<DateTimeOffset, int> AveragePrices { get; set; }


        public GraphData(Dictionary<string, int> Daily, Dictionary<string, int> Average)
        {
            DailyPrices = new Dictionary<DateTimeOffset, int>();
            AveragePrices = new Dictionary<DateTimeOffset, int>();

            foreach (var Entry in Daily)
            {
                var Time = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(Entry.Key));
                var Price = Entry.Value;

                DailyPrices.Add(Time, Price);
            }

            foreach (var Entry in Average)
            {
                var Time = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(Entry.Key));
                var Price = Entry.Value;

                AveragePrices.Add(Time, Price);
            }
        }
    }
}
