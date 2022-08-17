using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class GroupClient : IGroupClient
{
    private readonly IConnection _connection;

    public GroupClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<Group>> GetAll()
    {
        return _connection.ExecuteRequest<List<Group>>("groups", null, null).ToReadOnlyListAsync();
    }

    public Task<Group> Create(Models.Requests.Group group)
    {
        return _connection.ExecuteRequest<Group>("groups", null, group, method: Method.Post);
    }

    public Task<Group> Update(int id, Models.Requests.Group group)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Group>("groups/{id}", parameters, group, method: Method.Put);
    }

    public Task<Group> Delete(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Group>("groups/{id}/delete", parameters, null, method: Method.Delete);
    }
}