using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class FlowParameter
{
    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("field")]
    public string Field { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
}