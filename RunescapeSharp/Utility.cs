using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace RunescapeSharp
{
    /// <summary>
    /// Collection of utility methods
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Use Newtonsoft's SerializeObject method to convert any object to Json
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns>JSON Representation of the inputted .NET Object</returns>
        public static string ToJson(this object value, Formatting format = Formatting.Indented)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Converters = new List<JsonConverter> { new StringEnumConverter() }
                };

                var SerializedValue = JsonConvert.SerializeObject(value, format, settings);
                return SerializedValue;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
