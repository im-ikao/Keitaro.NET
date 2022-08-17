using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses
{
    public class Error
    {
        /// <summary>
        /// Detailed error message
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Message { get; set; }
    }
}