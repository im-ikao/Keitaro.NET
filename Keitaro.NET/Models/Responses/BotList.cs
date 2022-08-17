using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class BotList
{
    [JsonProperty("value")] 
    public string Value { get; set; }
}