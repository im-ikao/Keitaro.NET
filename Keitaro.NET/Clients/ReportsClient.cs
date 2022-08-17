using Keitaro.NET.Http;
using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;
using RestSharp;

namespace Keitaro.NET.Clients;

public class ReportsClient : IReportsClient
{
    private readonly IConnection _connection;

    public ReportsClient(IConnection connection) 
    {
        _connection = connection;
    }
    
    public Task<Report> GetCustomReport(CustomReportSettings settings)
    {
        return _connection.ExecuteRequest<Report>("report/build", null, settings, method: Method.Post);
    }

    public Task<Success> GetLabels(int campaignId, string labelName, string refName)
    {
        var parameters = new List<Parameter> {
            new QueryParameter("campaign_id",campaignId.ToString()),
            new QueryParameter("label_name", labelName),
            new QueryParameter("ref_name", refName)
        };
        
        return _connection.ExecuteRequest<Success>("report/labels", parameters, null, method: Method.Get);
    }

    public Task<Success> UpdateLabels(Label label)
    {
        return _connection.ExecuteRequest<Success>("report/labels", null, null, method: Method.Post);
    }
}