using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public partial class ClickCost
{
    [JsonProperty("campaign_ids")]
    public long[] CampaignIds { get; set; }

    [JsonProperty("costs")]
    public Cost[] Costs { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("only_campaign_uniques")]
    public long OnlyCampaignUniques { get; set; }
}

public class Cost
{
    [JsonProperty("start_date")]
    public string StartDate { get; set; }

    [JsonProperty("end_date")]
    public string EndDate { get; set; }

    [JsonProperty("cost")]
    public string CostCost { get; set; }

    [JsonProperty("filters")]
    public Dictionary<string, string> Filters { get; set; }
}