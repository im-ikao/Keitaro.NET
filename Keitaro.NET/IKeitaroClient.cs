using Keitaro.NET.Clients;

namespace Keitaro.NET;

public interface IKeitaroClient
{ 
    public IDomainsClient Domains { get; }
    public ICampaignsClient Campaigns { get; }
    public IAffiliateNetworksClient AffiliateNetworks { get; }
    public IBotsClient Bots { get; }
    public IClicksClient Clicks { get; }
    public IGroupClient Groups { get; }
    public ILogsClient Logs { get; }
    public IReportsClient Reports { get; }
    public IFlowsClient Flows { get; }
}