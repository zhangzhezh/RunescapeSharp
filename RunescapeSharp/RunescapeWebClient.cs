using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeSharp
{
    /// <summary>
    /// Extends HttpClient for additional functionality
    /// </summary>
    public class RunescapeWebClient : HttpClient
    {
        /// <summary>
        /// Gets the content of a Response as a string, given a Url to send the Request to.
        /// </summary>
        /// <param name="RequestUrl"></param>
        /// <returns>string</returns>
        public async Task<string> GetResponseAsString(string RequestUrl)
        {
            string ResponseString = null;

            try
            {
                HttpResponseMessage Response = await GetAsync(RequestUrl);

                if (Response.IsSuccessStatusCode)
                {
                    ResponseString = await Response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return ResponseString;
        }
    }
}
