using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public interface ICampaignsClient
{
    /// <summary>
    /// Retrieve a list of all campaigns in your account
    /// </summary>
    Task<IReadOnlyList<Campaign>> GetAll();

    /// <summary>
    /// Create a new campaign
    /// </summary>
    Task<Campaign> Create(Models.Requests.Campaign campaign);
    
    /// <summary>
    /// Clone a new campaign
    /// </summary>
    Task<Campaign> Clone(int id, Models.Requests.Campaign campaign);
    
    /// <summary>
    /// Retrieve a specific campaign
    /// </summary>
    Task<Campaign> Get(int id);
    
    /// <summary>
    /// Update a campaign
    /// </summary>
    Task<Campaign> Update(int id, Models.Requests.Campaign campaign);
    
    /// <summary>
    /// Archive a campaign
    /// </summary>
    Task<Campaign> Archive(int id);
    
    /// <summary>
    /// Enable a campaign
    /// </summary>
    Task<Campaign> Enable(int id);
    
    /// <summary>
    /// Disable a campaign
    /// </summary>
    Task<Campaign> Disable(int id);

    /// <summary>
    /// Update campaign costs
    /// </summary>
    void UpdateCosts(int id, Models.Requests.Costs costs);

    /// <summary>
    /// Archive a campaign
    /// </summary>
    Task<Campaign> Restore(int id);

    /// <summary>
    /// Retrieve a list of all campaigns in your account
    /// </summary>
    Task<IReadOnlyList<Campaign>> GetAllDeleted();
}