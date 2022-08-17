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
    }

    public IDomainsClient Domains { get; }
}