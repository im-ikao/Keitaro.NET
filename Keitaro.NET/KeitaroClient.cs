using Keitaro.NET.Clients;
using Keitaro.NET.Http;
using RestSharp;

namespace Keitaro.NET;

public class KeitaroClient : IKeitaroClient
{
    public readonly string KeitaroApiUrl;
    private readonly IConnection _connection;
    
    public KeitaroClient(string token, string keitaroApiUrl)
    {
        KeitaroApiUrl = keitaroApiUrl;
        
        var client = new RestClient(KeitaroApiUrl) {
            Options =
            {
                UserAgent = "Keitaro.NET"
            }
        };
        
        client.AddDefaultHeader("Api-Key", $"{token}");
        
        _connection = new Connection(client);
        
        Domains = new DomainsClient(_connection);
        Campaigns = new CampaignsClient(_connection);
        AffiliateNetworks = new AffiliateNetworksClient(_connection);
        Bots = new BotsClient(_connection);
        Clicks = new ClicksClient(_connection);
        Groups = new GroupClient(_connection);
        Logs = new LogsClient(_connection);
        Reports = new ReportsClient(_connection);
    }

    public IDomainsClient Domains { get; }
    public ICampaignsClient Campaigns { get; }
    public IAffiliateNetworksClient AffiliateNetworks { get; }
    public IBotsClient Bots { get; }
    public IClicksClient Clicks { get; }
    public IGroupClient Groups { get; }
    public ILogsClient Logs { get; }
    public IReportsClient Reports { get; }
}