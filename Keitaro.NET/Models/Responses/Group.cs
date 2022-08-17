using Keitaro.NET.Models.Requests;
using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Group
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("position")]
    public long Position { get; set; }

    [JsonProperty("type")]
    public GroupType Type { get; set; }
}