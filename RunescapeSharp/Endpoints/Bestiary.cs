using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RunescapeSharp.Interfaces;

namespace RunescapeSharp.Endpoints
{
    /// <summary>
    /// Represents an instance of the 'Bestiary' API endpoint
    /// </summary>
    public sealed class Bestiary : IEndpoint
    {
        /// <summary>
        /// Get an instance of Bestiary given a RunescapeClient
        /// </summary>
        /// <param name="Client"></param>
        public Bestiary(RunescapeWebClient Client)
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
