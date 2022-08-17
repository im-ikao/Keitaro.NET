using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class Bot
{
    [JsonProperty("value")] 
    public string Value { get; set; }
}