using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class Domain
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("default_campaign_id")]
    public int DefaultCampaignId { get; set; }

    [JsonProperty("wildcard")]
    public bool Wildcard { get; set; }

    [JsonProperty("catch_not_found")]
    public bool CatchNotFound { get; set; }

    [JsonProperty("notes")]
    public string Notes { get; set; }

    [JsonProperty("ssl_redirect")]
    public bool SslRedirect { get; set; }

    [JsonProperty("allow_indexing")]
    public bool AllowIndexing { get; set; }
}