using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RunescapeSharp.Endpoints.GrandExchange_Objects;
using RunescapeSharp.Enumerations;
using RunescapeSharp.Interfaces;

namespace RunescapeSharp.Endpoints
{
    /// <summary>
    /// Represents an instance of the 'Grand Exchange' API endpoint
    /// </summary>
    public sealed class GrandExchange : IEndpoint
    {
        private const string GE_BASE_ADDRESS = "/m=itemdb_rs/api/";

        /// <summary>
        /// Get an instance of GrandExchange given a RunescapeClient
        /// </summary>
        /// <param name="Client"></param>
        public GrandExchange(RunescapeWebClient Client)
        {
            client = Client;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RunescapeWebClient client;

        RunescapeWebClient IEndpoint.Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        #region Asynchronous
        public async Task<Category> GetCategoryByLetterAsync(int CategoryNumber)
        {
            return await Task.Factory.StartNew(() =>
                JsonConvert.DeserializeObject<Category>(client.GetResponseAsString($"{GE_BASE_ADDRESS}catalogue/category.json?category={CategoryNumber}").Result));
        }

        public async Task<Runedate> GetRunedateAsync()
        {
            return await Task.Factory.StartNew(() =>
                JsonConvert.DeserializeObject<Runedate>(client.GetResponseAsString($"{GE_BASE_ADDRESS}info.json").Result));
        }

        public async Task<CategoryPrices> GetItemsInCategoryAsync(GrandExchangeCategories Category, string StartingLetter, int PageNumber)
        {
            return await Task.Factory.StartNew(() =>
                JsonConvert.DeserializeObject<CategoryPrices>(client.GetResponseAsString
                ($"{GE_BASE_ADDRESS}catalogue/items.json?category={(int)Category}&alpha={StartingLetter}&page={PageNumber}").Result));
        }

        public async Task<Item> GetItemDetailAsync(string ItemId)
        {
            return await Task.Factory.StartNew(() =>
                JObject.Parse(client.GetResponseAsString($"{GE_BASE_ADDRESS}catalogue/detail.json?item={ItemId}").Result).SelectToken("item", false).ToObject<Item>());
        }

        public async Task<GraphData> GetGraphAsync(string ItemId)
        {
            return await Task.Factory.StartNew(() =>
                JsonConvert.DeserializeObject<GraphData>(client.GetResponseAsString($"{GE_BASE_ADDRESS}graph/{ItemId}.json").Result));
        }

        #endregion

        #region Synchronous
        public Category GetCategoryByLetter(int CategoryNumber)
        {
            return GetCategoryByLetterAsync(CategoryNumber).Result;
        }

        public Runedate GetRunedate()
        {
            return GetRunedateAsync().Result;
        }

        public CategoryPrices GetItemsInCategory(GrandExchangeCategories Category, string StartingLetter, int PageNumber)
        {
            return GetItemsInCategoryAsync(Category, StartingLetter, PageNumber).Result;
        }

        public Item GetItemDetail(string ItemId)
        {
            return GetItemDetailAsync(ItemId).Result;
        }

        public string GetIconUrl(IconTypes Type, string ItemId)
        {
            var PathAddition = (Type == IconTypes.Big) ? "obj_big" : "obj_sprite";

            return $"{client.BaseAddress}m=itemdb_rs/{PathAddition}.gif?id={ItemId}";
        }

        public GraphData GetGraph(string ItemId)
        {
            return GetGraphAsync(ItemId).Result;
        }

        #endregion
    }
}
