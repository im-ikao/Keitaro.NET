using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class Label
{
    [JsonProperty("campaign_id")]
    public long CampaignId { get; set; }

    [JsonProperty("ref_name")]
    public string RefName { get; set; }

    [JsonProperty("items")]
    public Items Items { get; set; }
}

public class Items
{
    [JsonProperty("value")]
    public string Value { get; set; }
}