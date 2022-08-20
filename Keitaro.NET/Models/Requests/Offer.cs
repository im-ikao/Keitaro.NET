using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class Offer
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("group_id")]
    public long GroupId { get; set; }

    [JsonProperty("offer_type")]
    public string OfferType { get; set; }

    [JsonProperty("action_type")]
    public string ActionType { get; set; }

    [JsonProperty("action_payload")]
    public object ActionPayload { get; set; }

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

    [JsonProperty("payout_auto")]
    public bool PayoutAuto { get; set; }

    [JsonProperty("payout_upsell")]
    public bool PayoutUpsell { get; set; }

    [JsonProperty("country")]
    public string[] Country { get; set; }

    [JsonProperty("notes")]
    public string Notes { get; set; }

    [JsonProperty("archive")]
    public string Archive { get; set; }

    [JsonProperty("conversion_cap_enabled")]
    public bool ConversionCapEnabled { get; set; }

    [JsonProperty("daily_cap")]
    public long DailyCap { get; set; }

    [JsonProperty("conversion_timezone")]
    public string ConversionTimezone { get; set; }

    [JsonProperty("alternative_offer_id")]
    public long AlternativeOfferId { get; set; }
}