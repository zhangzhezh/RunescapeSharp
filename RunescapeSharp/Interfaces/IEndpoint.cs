using System.Net.Http;

namespace RunescapeSharp.Interfaces
{
    /// <summary>
    /// Implementations of this represent an endpoint
    /// </summary>
    public interface IEndpoint
    {
        /// <summary>
        /// The RunescapeClient used to make web service calls on any given IEndpoint implementation
        /// </summary>
        RunescapeWebClient Client { get; set; }
    }
}
