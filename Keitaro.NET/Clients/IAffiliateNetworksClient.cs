using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IAffiliateNetworksClient
{
    /// <summary>
    /// Retrieve a list of all affiliate networks in your account
    /// </summary>
    Task<IReadOnlyList<AffiliateNetwork>> GetAll();
    
    /// <summary>
    /// Create a new affiliate network
    /// </summary>
    Task<AffiliateNetwork> Create(Models.Requests.AffiliateNetwork network);
    
    /// <summary>
    /// Clone a new affiliate network
    /// </summary>
    Task<AffiliateNetwork> Clone(int id, Models.Requests.AffiliateNetwork network);
    
    /// <summary>
    /// Retrieve a specific affiliate network
    /// </summary>
    Task<AffiliateNetwork> Get(int id);
    
    /// <summary>
    /// Update a affiliate network
    /// </summary>
    Task<AffiliateNetwork> Update(int id, Models.Requests.AffiliateNetwork network);
    
    /// <summary>
    /// Archive a affiliate network
    /// </summary>
    Task<AffiliateNetwork> Archive(int id);
}