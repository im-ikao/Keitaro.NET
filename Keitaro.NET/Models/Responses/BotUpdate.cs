using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class BotUpdate
{
    [JsonProperty("count")] 
    public string Count { get; set; }
}