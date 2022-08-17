using Keitaro.NET.Extensions;
using Keitaro.NET.Http;
using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class ClicksClient : IClicksClient
{
    private readonly IConnection _connection;

    public ClicksClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<IReadOnlyList<Report>> GetAll(ReportSettings reportSettingsSettings)
    {
        return _connection.ExecuteRequest<List<Report>>("clicks/log", null, reportSettingsSettings, method: Method.Post).ToReadOnlyListAsync();
    }

    public Task<Success> UpdateCosts(ClickCost costs)
    {
        return _connection.ExecuteRequest<Success>("clicks/update_costs", null, costs, method: Method.Post);
    }
}