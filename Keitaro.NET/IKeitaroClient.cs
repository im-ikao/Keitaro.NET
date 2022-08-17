using Keitaro.NET.Clients;

namespace Keitaro.NET;

public interface IKeitaroClient
{ 
    public IDomainsClient Domains { get; }
}