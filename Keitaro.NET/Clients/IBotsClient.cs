using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IBotsClient
{
    /// <summary>
    /// Retrieve a list of all bots in your account
    /// </summary>
    Task<BotList> GetAll();
    
    /// <summary>
    /// Update bot list in you account
    /// </summary>
    Task<BotUpdate> Update(Models.Requests.Bot value);

    /// <summary>
    /// Add bot to bot list in you account
    /// </summary>
    Task<BotUpdate> Add(Models.Requests.Bot value);
    
    /// <summary>
    /// Remove bot from bot list in you account
    /// </summary>
    Task<BotUpdate> Remove(Models.Requests.Bot value);
    
    /// <summary>
    /// Clear bot list in you account
    /// </summary>
    void Clear();
}