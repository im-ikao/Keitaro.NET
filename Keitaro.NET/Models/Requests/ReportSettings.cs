using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class ReportSettings
{
    [JsonProperty("range")]
    public Range Range { get; set; }

    [JsonProperty("limit")]
    public long Limit { get; set; }

    [JsonProperty("offset")]
    public long Offset { get; set; }

    [JsonProperty("columns")]
    public string[] Columns { get; set; }

    [JsonProperty("filters")]
    public Filter[] Filters { get; set; }

    [JsonProperty("sort")]
    public Sort[] Sort { get; set; }
}

public class Filter
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("operator")]
    public string Operator { get; set; }

    [JsonProperty("expression")]
    public string Expression { get; set; }
}

public class Range
{
    [JsonProperty("from")]
    public string From { get; set; }

    [JsonProperty("to")]
    public string To { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("interval")]
    public object Interval { get; set; }
}

public class Sort
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("order")]
    public string Order { get; set; }
}