using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RunescapeSharp.Endpoints;

namespace RunescapeSharp
{
    /// <summary>
    /// Represents an instance of the Runescape API.
    /// </summary>
    public class RunescapeAPI
    {
        /// <summary>
        /// Instance of GrandExchange associated with this RunescapeAPI
        /// </summary>
        public GrandExchange GrandExchange;

        /// <summary>
        /// Instance of Hiscores associated with this RunescapeAPI
        /// </summary>
        public Hiscores Hiscores;

        /// <summary>
        /// Instance of Bestiary associated with this RunescapeAPI
        /// </summary>
        public Bestiary Bestiary;

        /// <summary>
        /// Creates a new RunescapeAPI and initializes the Client with the correct settings
        /// </summary>
        /// <returns>RunescapeAPI</returns>
        public static RunescapeAPI GetInstance()
        {
            return new RunescapeAPI(new RunescapeWebClient());
        }

        private RunescapeAPI(RunescapeWebClient Client)
        {
            Client.BaseAddress = new Uri($@"http://services.runescape.com/");

            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            GrandExchange = new GrandExchange(Client);
            Bestiary = new Bestiary(Client);
            Hiscores = new Hiscores(Client);
        }
    }
}
