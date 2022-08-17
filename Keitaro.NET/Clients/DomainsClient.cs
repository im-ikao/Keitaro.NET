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
        return _connection.ExecuteRequest<List<Domain>>("domains", null, "domains").ToReadOnlyListAsync();
    }

    public Task<Domain> Create(Models.Requests.Domain domain)
    {
        return _connection.ExecuteRequest<Domain>("domains", null, domain, method: Method.Post);
    }

    public Task<Domain> Get(int domainId)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("name",domainId.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{name}", parameters, null);
    }

    public Task<Domain> Update(Models.Requests.Domain domain)
    {
        return _connection.ExecuteRequest<Domain>("domains", null, domain, method: Method.Put);
    }

    public Task<Domain> Archive(int domainId)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("name",domainId.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{name}", parameters, null, method: Method.Delete);
    }

    public Task<Domain> UpdateStatus(int domainId)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("name",domainId.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{name}/check", parameters, null, method: Method.Post);
    }

    public Task<Domain> Restore(int domainId)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("name",domainId.ToString())
        };
        
        return _connection.ExecuteRequest<Domain>("domains/{name}/restore", parameters, null, method: Method.Post);
    }

    public Task<IReadOnlyList<Domain>> GetAllDeleted()
    {
        return _connection.ExecuteRequest<List<Domain>>("domains/deleted", null, "domains").ToReadOnlyListAsync();
    }
}