using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Keitaro.NET.Models.Responses;

public class Log
{
    [JsonProperty("datetime")]
    public string Datetime { get; set; }

    [JsonProperty("jid")]
    public string Jid { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }
}

public enum LogType
{
    [EnumMember(Value = "system")]
    System,
    
    [EnumMember(Value = "traffic")]
    Traffic,
    
    [EnumMember(Value = "postbacks")]
    Postback,
    
    [EnumMember(Value = "ssl")]
    Ssl,
    
    [EnumMember(Value = "sent_postbacks")]
    SentPostback
}