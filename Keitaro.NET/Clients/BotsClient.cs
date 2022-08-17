using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class BotsClient : IBotsClient
{
    private readonly IConnection _connection;

    public BotsClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<BotList> GetAll()
    {
        return _connection.ExecuteRequest<BotList>("botlist", null, null);
    }

    public Task<BotUpdate> Update(Bot bots)
    {
        return _connection.ExecuteRequest<BotUpdate>("botlist", null, bots, method: Method.Put);
    }

    public Task<BotUpdate> Add(Bot bots)
    {
        return _connection.ExecuteRequest<BotUpdate>("botlist/add", null, bots, method: Method.Post);

    }

    public Task<BotUpdate> Remove(Bot bots)
    {
        return _connection.ExecuteRequest<BotUpdate>("botlist/exclude", null, bots, method: Method.Post);
    }

    public async void Clear()
    {
        await _connection.ExecuteRaw("botlist", null, null, method: Method.Delete);
    }
}