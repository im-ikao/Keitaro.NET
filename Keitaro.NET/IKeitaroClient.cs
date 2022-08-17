using Keitaro.NET.Clients;

namespace Keitaro.NET;

public interface IKeitaroClient
{ 
    public IDomainsClient Domains { get; }
    public ICampaignsClient Campaigns { get; }
    public IAffiliateNetworksClient AffiliateNetworks { get; }
}