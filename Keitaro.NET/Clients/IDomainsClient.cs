using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IDomainsClient
{
    /// <summary>
    /// Retrieve a list of all domains in your account
    /// </summary>
    Task<IReadOnlyList<Domain>> GetAll();

    /// <summary>
    /// Create a new domain
    /// </summary>
    Task<Domain> Create(Models.Requests.Domain domain);
    
    /// <summary>
    /// Retrieve a specific domain
    /// </summary>
    Task<Domain> Get(int domainId);
    
    /// <summary>
    /// Update a domain
    /// </summary>
    Task<Domain> Update(int domainId, Models.Requests.Domain domain);
    
    /// <summary>
    /// Archive a domain
    /// </summary>
    Task<Domain> Archive(int domainId);

    /// <summary>
    /// Update domain status
    /// </summary>
    Task<Domain> UpdateStatus(int domainId);

    /// <summary>
    /// Archive a domain
    /// </summary>
    Task<Domain> Restore(int domainId);

    /// <summary>
    /// Retrieve a list of all domains in your account
    /// </summary>
    Task<IReadOnlyList<Domain>> GetAllDeleted();

}