using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IGroupClient
{
    /// <summary>
    /// Retrieve a list of all groups in your account
    /// </summary>
    Task<IReadOnlyList<Group>> GetAll();
    
    /// <summary>
    /// Retrieve a list of all groups in your account
    /// </summary>
    Task<Group> Create(Models.Requests.Group group);
    
    /// <summary>
    /// Retrieve a list of all groups in your account
    /// </summary>
    Task<Group> Update(int id, Models.Requests.Group group);
    
    /// <summary>
    /// Retrieve a list of all groups in your account
    /// </summary>
    Task<Group> Delete(int id);
}