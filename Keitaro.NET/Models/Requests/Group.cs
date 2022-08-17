using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Keitaro.NET.Models.Requests;

public class Group
{
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("type")]
    public Type Type { get; set; }
}

public enum GroupType
{
    [EnumMember(Value = "campaigns")]
    Campaign,
    
    [EnumMember(Value = "offers")]
    Offer,
    
    [EnumMember(Value = "landing")] 
    Landing
}