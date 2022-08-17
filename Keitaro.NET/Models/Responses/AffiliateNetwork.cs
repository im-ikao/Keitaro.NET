using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class AffiliateNetwork
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("postback_url")]
    public string PostbackUrl { get; set; }

    [JsonProperty("offer_param")]
    public string OfferParam { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("template_name")]
    public string TemplateName { get; set; }

    [JsonProperty("notes")]
    public string Notes { get; set; }

    [JsonProperty("pull_api_options")]
    public string PullApiOptions { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonProperty("offers")]
    public int Offers { get; set; }
}