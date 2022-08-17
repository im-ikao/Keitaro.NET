using System.Net;
using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Requests;
using RestSharp;
using Campaign = Keitaro.NET.Models.Responses.Campaign;

namespace Keitaro.NET.Clients;

public class CampaignsClient : ICampaignsClient
{
    private readonly IConnection _connection;

    public CampaignsClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<Campaign>> GetAll()
    {
        return _connection.ExecuteRequest<List<Campaign>>("campaigns", null, null).ToReadOnlyListAsync();
    }

    public Task<Campaign> Create(Models.Requests.Campaign campaign)
    {
        return _connection.ExecuteRequest<Campaign>("campaigns", null, campaign, method: Method.Post);    
    }

    public Task<Campaign> Clone(int id, Models.Requests.Campaign campaign)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaigns/{id}/clone", parameters, campaign, method: Method.Post);
    }

    public Task<Campaign> Get(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaign/{id}", parameters, null);
    }

    public Task<Campaign> Update(int id, Models.Requests.Campaign campaign)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaigns/{id}", parameters, campaign, method: Method.Put);
    }

    public Task<Campaign> Archive(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id",id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaigns/{id}", parameters, null, method: Method.Delete);
    }

    public Task<Campaign> Enable(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaigns/{id}/enable", parameters, null, method: Method.Post);
    }

    public Task<Campaign> Disable(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaigns/{id}/disable", parameters, null, method: Method.Post);
    }

    public async void UpdateCosts(int id, CampaignCosts campaignCosts)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        await _connection.ExecuteRaw("campaigns/{id}/update_costs", parameters, campaignCosts, method: Method.Post);
    }

    public Task<Campaign> Restore(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Campaign>("campaigns/{id}/restore", parameters, null, method: Method.Post);
    }

    public Task<IReadOnlyList<Campaign>> GetAllDeleted()
    {
        return _connection.ExecuteRequest<List<Campaign>>("campaigns/deleted", null, null).ToReadOnlyListAsync();
    }
}