using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Campaign
{
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cookies_ttl")]
        public long CookiesTtl { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("cost_type")]
        public string CostType { get; set; }

        [JsonProperty("cost_value")]
        public long CostValue { get; set; }

        [JsonProperty("cost_currency")]
        public string CostCurrency { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("bind_visitors")]
        public string BindVisitors { get; set; }

        [JsonProperty("traffic_source_id")]
        public long TrafficSourceId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("cost_auto")]
        public bool CostAuto { get; set; }

        [JsonProperty("parameters")]
        public Dictionary<string, Macros> Parameters { get; set; }

        [JsonProperty("postbacks")]
        public Postback[] Postbacks { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class Macros
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

public class Postback
{
    [JsonProperty("campaign_id")] 
    public long CampaignId { get; set; }

    [JsonProperty("id")] 
    public long Id { get; set; }

    [JsonProperty("method")] 
    public string Method { get; set; }

    [JsonProperty("statuses")] 
    public string[] Statuses { get; set; }

    [JsonProperty("url")] 
    public string Url { get; set; }
}