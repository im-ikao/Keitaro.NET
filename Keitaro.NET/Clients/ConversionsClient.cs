using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class ConversionsClient : IConversionsClient
{
    private readonly IConnection _connection;

    public ConversionsClient(IConnection connection) 
    {
        _connection = connection;
    }

    public Task<IReadOnlyList<Report>> GetAll(ReportSettings reportSettingsSettings)
    {
        return _connection.ExecuteRequest<List<Report>>("conversions/log", null, reportSettingsSettings, method: Method.Post).ToReadOnlyListAsync();
    }
}