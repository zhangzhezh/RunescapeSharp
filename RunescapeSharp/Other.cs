using System.Diagnostics;
using RunescapeSharp.Interfaces;

namespace RunescapeSharp.Endpoints
{
    public class Other : IEndpoint
    {
        /// <summary>
        /// Get an instance of Other given a RunescapeClient
        /// </summary>
        /// <param name="Client"></param>
        public Other(RunescapeWebClient Client)
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
    }
}