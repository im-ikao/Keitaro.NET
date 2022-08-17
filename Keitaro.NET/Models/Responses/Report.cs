using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Report
{
    [JsonProperty("rows")]
    public string[] Rows { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("meta")]
    public string[] Meta { get; set; }
}