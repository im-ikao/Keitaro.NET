using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class AffiliateNetworksClient : IAffiliateNetworksClient
{
    private readonly IConnection _connection;

    public AffiliateNetworksClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<AffiliateNetwork>> GetAll()
    {
        return _connection.ExecuteRequest<List<AffiliateNetwork>>("affiliate_networks", null, null).ToReadOnlyListAsync();
    }

    public Task<AffiliateNetwork> Create(Models.Requests.AffiliateNetwork network)
    {
        return _connection.ExecuteRequest<AffiliateNetwork>("affiliate_networks", null, network, method: Method.Post);    
    }

    public Task<AffiliateNetwork> Clone(int id, Models.Requests.AffiliateNetwork network)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<AffiliateNetwork>("affiliate_networks/{id}/clone", parameters, network, method: Method.Post);
    }

    public Task<AffiliateNetwork> Get(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<AffiliateNetwork>("affiliate_networks/{id}", parameters, null);
    }

    public Task<AffiliateNetwork> Update(int id, Models.Requests.AffiliateNetwork network)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<AffiliateNetwork>("affiliate_networks/{id}", parameters, network, method: Method.Put);
    }

    public Task<AffiliateNetwork> Archive(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<AffiliateNetwork>("affiliate_networks/{id}", parameters, null, method: Method.Delete);
    }
}