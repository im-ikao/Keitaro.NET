using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class CustomReportSettings
{
    [JsonProperty("range")]
    public Range Range { get; set; }

    [JsonProperty("grouping")]
    public string[] Grouping { get; set; }

    [JsonProperty("metrics")]
    public string[] Metrics { get; set; }

    [JsonProperty("filters")]
    public ReportFilter[] Filters { get; set; }

    [JsonProperty("sort")]
    public Sort[] Sort { get; set; }
}