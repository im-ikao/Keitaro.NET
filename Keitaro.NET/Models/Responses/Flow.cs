using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Flow
{
 [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("campaign_id")]
        public long CampaignId { get; set; }

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

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("action_payload")]
        public string ActionPayload { get; set; }

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
        public Landing[] Offers { get; set; }
    }


    public class Filter
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("stream_id")]
        public long StreamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }
    }

    public class Landing
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("stream_id")]
        public long StreamId { get; set; }

        [JsonProperty("landing_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? LandingId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("share")]
        public long Share { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("offer_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? OfferId { get; set; }
    }

public class Trigger
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("oid")] public long Oid { get; set; }

    [JsonProperty("stream_id")] public long StreamId { get; set; }

    [JsonProperty("taget")] public string Taget { get; set; }

    [JsonProperty("condition")] public string Condition { get; set; }

    [JsonProperty("selected_page")] public string SelectedPage { get; set; }

    [JsonProperty("pattern")] public string Pattern { get; set; }

    [JsonProperty("action")] public string Action { get; set; }

    [JsonProperty("interval")] public long Interval { get; set; }

    [JsonProperty("next_run_at")] public long NextRunAt { get; set; }

    [JsonProperty("alternative_urls")] public string AlternativeUrls { get; set; }

    [JsonProperty("grab_from_page")] public string GrabFromPage { get; set; }

    [JsonProperty("av_settings")] public string AvSettings { get; set; }

    [JsonProperty("reverse")] public bool Reverse { get; set; }

    [JsonProperty("enabled")] public bool Enabled { get; set; }

    [JsonProperty("scan_page")] public bool ScanPage { get; set; }
}