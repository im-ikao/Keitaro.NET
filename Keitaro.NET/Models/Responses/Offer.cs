using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Offer
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("group_id")]
    public long GroupId { get; set; }

    [JsonProperty("action_type")]
    public string ActionType { get; set; }

    [JsonProperty("action_payload")]
    public string ActionPayload { get; set; }

    [JsonProperty("action_options")]
    public object ActionOptions { get; set; }

    [JsonProperty("affiliate_network_id")]
    public long AffiliateNetworkId { get; set; }

    [JsonProperty("payout_value")]
    public long PayoutValue { get; set; }

    [JsonProperty("payout_currency")]
    public string PayoutCurrency { get; set; }

    [JsonProperty("payout_type")]
    public string PayoutType { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonProperty("payout_auto")]
    public bool PayoutAuto { get; set; }

    [JsonProperty("payout_upsell")]
    public bool PayoutUpsell { get; set; }

    [JsonProperty("country")]
    public string[] Country { get; set; }

    [JsonProperty("notes")]
    public string Notes { get; set; }

    [JsonProperty("affiliate_network")]
    public string AffiliateNetwork { get; set; }

    [JsonProperty("archive")]
    public string Archive { get; set; }

    [JsonProperty("local_path")]
    public string LocalPath { get; set; }

    [JsonProperty("preview_path")]
    public string PreviewPath { get; set; }
}