using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class AffiliateNetwork
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("postback_url")]
    public string PostbackUrl { get; set; }

    [JsonProperty("offer_param")]
    public string OfferParam { get; set; }

    [JsonProperty("notes")]
    public string Notes { get; set; }
}