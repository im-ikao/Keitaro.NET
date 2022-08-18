using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;
using RestSharp;
using Flow = Keitaro.NET.Models.Responses.Flow;

namespace Keitaro.NET.Clients;

public class FlowsClient : IFlowsClient
{
    private readonly IConnection _connection;

    public FlowsClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<Flow>> GetAll(int campaignId)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", campaignId.ToString())
        };
        
        return _connection.ExecuteRequest<List<Flow>>("campaigns/{id}/streams", parameters, null).ToReadOnlyListAsync();
    }

    public Task<IReadOnlyList<FlowFilter>> GetAvailableFilters()
    {
        return _connection.ExecuteRequest<List<FlowFilter>>("stream_filters", null, null).ToReadOnlyListAsync();
    }

    public Task<IReadOnlyList<FlowParameter>> GetAvailableSchemas()
    {
        return _connection.ExecuteRequest<List<FlowParameter>>("stream_schemas", null, null).ToReadOnlyListAsync();
    }

    public Task<IReadOnlyList<FlowParameter>> GetTypes()
    {
        return _connection.ExecuteRequest<List<FlowParameter>>("stream_types", null, null).ToReadOnlyListAsync();
    }

    public Task<IReadOnlyList<FlowParameter>> GetActions()
    {
        return _connection.ExecuteRequest<List<FlowParameter>>("stream_actions", null, null).ToReadOnlyListAsync();
    }

    public Task<Flow> Create(Models.Requests.Flow flow)
    {
        return _connection.ExecuteRequest<Flow>("streams", null, flow, method: Method.Post);
    }

    public Task<Flow> Get(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}", parameters, null);
    }

    public Task<Flow> Update(int id, Models.Requests.Flow flow)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}", parameters, flow, method: Method.Post);
    }

    public Task<Flow> Delete(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}", parameters, null, method: Method.Delete);
    }

    public Task<Flow> Enable(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}/enable", parameters, null, method: Method.Post);
    }

    public Task<Flow> Disable(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}/disable", parameters, null, method: Method.Post);
    }

    public Task<Flow> GetEvents(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}/events", parameters, null, method: Method.Get);
    }

    public Task<Flow> Restore(int id)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("id", id.ToString())
        };
        
        return _connection.ExecuteRequest<Flow>("streams/{id}/restore", parameters, null, method: Method.Post);
    }

    public Task<IReadOnlyList<Flow>> GetAllDeleted()
    {
        return _connection.ExecuteRequest<List<Flow>>("streams/deleted", null, null, method: Method.Get).ToReadOnlyListAsync();
    }

    public Task<IReadOnlyList<Flow>> Find(string query)
    {
        var parameters = new List<Parameter> {
            new QueryParameter("query", query)
        };
        
        return _connection.ExecuteRequest<List<Flow>>("streams/search", parameters, null, method: Method.Get).ToReadOnlyListAsync();
    }
}