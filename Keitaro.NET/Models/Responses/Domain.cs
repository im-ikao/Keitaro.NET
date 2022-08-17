using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Domain
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("network_status")]
    public string NetworkStatus { get; set; }

    [JsonProperty("default_campaign")]
    public string DefaultCampaign { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonProperty("wildcard")]
    public bool Wildcard { get; set; }

    [JsonProperty("catch_not_found")]
    public bool CatchNotFound { get; set; }

    [JsonProperty("notes")]
    public string Notes { get; set; }

    [JsonProperty("campaigns_count")]
    public int CampaignsCount { get; set; }

    [JsonProperty("ssl_redirect")]
    public bool SslRedirect { get; set; }

    [JsonProperty("allow_indexing")]
    public bool AllowIndexing { get; set; }
}