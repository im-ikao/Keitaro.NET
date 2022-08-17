using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public interface ICampaignsClient
{
    /// <summary>
    /// Retrieve a list of all domains in your account
    /// </summary>
    Task<IReadOnlyList<Campaign>> GetAll();

    /// <summary>
    /// Create a new domain
    /// </summary>
    Task<Campaign> Create(Models.Requests.Campaign campaign);
    
    /// <summary>
    /// Create a new domain
    /// </summary>
    Task<Campaign> Clone(int campaignId, Models.Requests.Campaign campaign);
    
    /// <summary>
    /// Retrieve a specific domain
    /// </summary>
    Task<Campaign> Get(int campaignId);
    
    /// <summary>
    /// Update a domain
    /// </summary>
    Task<Campaign> Update(int campaignId, Models.Requests.Campaign campaign);
    
    /// <summary>
    /// Archive a domain
    /// </summary>
    Task<Campaign> Archive(int campaignId);
    
    /// <summary>
    /// Archive a domain
    /// </summary>
    Task<Campaign> Enable(int campaignId);
    
    /// <summary>
    /// Archive a domain
    /// </summary>
    Task<Campaign> Disable(int campaignId);

    /// <summary>
    /// Update domain status
    /// </summary>
    void UpdateCosts(int campaignId, Models.Requests.Costs costs);

    /// <summary>
    /// Archive a domain
    /// </summary>
    Task<Campaign> Restore(int campaignId);

    /// <summary>
    /// Retrieve a list of all domains in your account
    /// </summary>
    Task<IReadOnlyList<Campaign>> GetAllDeleted();
}