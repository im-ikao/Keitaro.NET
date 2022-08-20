using Keitaro.NET.Models.Responses;
using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class Flow
{
    [JsonProperty("campaign_id")]
    public long CampaignId { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("position")]
    public long Position { get; set; }

    [JsonProperty("weight")]
    public long Weight { get; set; }

    [JsonProperty("action_options")]
    public object ActionOptions { get; set; }

    [JsonProperty("comments")]
    public string Comments { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("action_type")]
    public string ActionType { get; set; }

    [JsonProperty("schema")]
    public string Schema { get; set; }

    [JsonProperty("collect_clicks")]
    public bool CollectClicks { get; set; }

    [JsonProperty("filter_or")]
    public bool FilterOr { get; set; }

    [JsonProperty("filters")]
    public Filter[] Filters { get; set; }

    [JsonProperty("triggers")]
    public Trigger[] Triggers { get; set; }

    [JsonProperty("landings")]
    public Landing[] Landings { get; set; }

    [JsonProperty("offers")]
    public Offer[] Offers { get; set; }
}

public class OfferFlow
{
    [JsonProperty("offer_id")]
    public long OfferId { get; set; }

    [JsonProperty("share")]
    public long Share { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }
}