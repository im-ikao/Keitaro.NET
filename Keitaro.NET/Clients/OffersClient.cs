using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class OffersClient : IOffersClient
{
    private readonly IConnection _connection;

    public OffersClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<Offer>> GetAll()
    {
        return _connection.ExecuteRequest<List<Offer>>("offers", null, null, method: Method.Get).ToReadOnlyListAsync();
    }

    public Task<Offer> Create(Models.Requests.Offer offer)
    {
        return _connection.ExecuteRequest<Offer>("offers", null, offer, method: Method.Post);
    }

    public Task<Offer> Get(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Offer>("offers/{id}", parameters, null, method: Method.Get);
    }

    public Task<Offer> Update(int id, Models.Requests.Offer offer)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Offer>("offers/{id}", parameters, offer, method: Method.Put);
    }

    public Task<Offer> Delete(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Offer>("offers/{id}", parameters, null, method: Method.Delete);    
    }

    public Task<Offer> Clone(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Offer>("offers/{id}/clone", parameters, null, method: Method.Post);    
    }
}