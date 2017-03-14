using System.Diagnostics;
using RunescapeSharp.Interfaces;

namespace RunescapeSharp.Endpoints
{
    public class RuneMetrics : IEndpoint
    {
        /// <summary>
        /// Get an instance of RuneMetrics given a RunescapeClient
        /// </summary>
        /// <param name="Client"></param>
        public RuneMetrics(RunescapeWebClient Client)
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