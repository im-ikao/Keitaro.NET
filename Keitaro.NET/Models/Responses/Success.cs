using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Success
{
    /// <summary>
    /// Detailed success message
    /// </summary>
    [JsonProperty(PropertyName = "success")]
    public bool State { get; set; }
}