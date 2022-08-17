using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class DomainsClient : IDomainsClient
{
    private readonly IConnection _connection;

    public DomainsClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<Domain>> GetAll()
    {
        return _connection.ExecuteRequest<List<Domain>>("domains", null, null).ToReadOnlyListAsync();
    }

    public Task<Domain> Create(Models.Requests.Domain domain)
    {
        return _connection.ExecuteRequest<Domain>("domains", null, domain, method: Method.Post);
    }

    public Task<Domain> Get(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{id}", parameters, null);
    }

    public Task<Domain> Update(int id, Models.Requests.Domain domain)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{id}", parameters, domain, method: Method.Put);
    }

    public Task<Domain> Archive(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{id}", parameters, null, method: Method.Delete);
    }

    public Task<Domain> UpdateStatus(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{id}/check", parameters, null, method: Method.Post);
    }

    public Task<Domain> Restore(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{id}/restore", parameters, null, method: Method.Post);
    }

    public Task<IReadOnlyList<Domain>> GetAllDeleted()
    {
        return _connection.ExecuteRequest<List<Domain>>("domains/deleted", null, null).ToReadOnlyListAsync();
    }
}