using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class CampaignCosts
{
    [JsonProperty("start_date")]
    public string StartDate { get; set; }

    [JsonProperty("end_date")]
    public string EndDate { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("cost")]
    public string Cost { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("only_campaign_uniques")]
    public bool OnlyCampaignUniques { get; set; }

    [JsonProperty("filters")]
    public Dictionary<string, string> Filters { get; set; }
}