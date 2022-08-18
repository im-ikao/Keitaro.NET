using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class FlowFilter
{
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("tooltip")]
    public string Tooltip { get; set; }

    [JsonProperty("modes")]
    public Modes Modes { get; set; }

    [JsonProperty("group")]
    public string Group { get; set; }

    [JsonProperty("template")]
    public string Template { get; set; }

    [JsonProperty("header_template")]
    public string HeaderTemplate { get; set; }

    [JsonProperty("defaults")]
    public string Defaults { get; set; }
}

public class Modes
{
    [JsonProperty("accept")]
    public string Accept { get; set; }

    [JsonProperty("reject")]
    public string Reject { get; set; }
}