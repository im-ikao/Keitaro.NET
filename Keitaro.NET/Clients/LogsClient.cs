using Keitaro.NET.Http;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class LogsClient : ILogsClient
{
    private readonly IConnection _connection;

    public LogsClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<Log> GetAll(LogType type)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("type", type.ToString())
        };
        
        return _connection.ExecuteRequest<Log>($"logs/{type}", parameters, null, method: Method.Get);
    }

    public async void Clean(LogType type)
    {
        var parameters = new List<Parameter> {
            new UrlSegmentParameter("type", type.ToString())
        };
        
        await _connection.ExecuteRaw($"logs/{type}", parameters, null, method: Method.Delete);
    }
}