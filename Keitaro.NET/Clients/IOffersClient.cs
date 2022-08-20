using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IOffersClient
{
    Task<IReadOnlyList<Offer>> GetAll();
    Task<Offer> Create(Models.Requests.Offer offer);
    Task<Offer> Get(int id);
    Task<Offer> Update(int id, Models.Requests.Offer offer);
    
    // TODO: Create File
    
    Task<Offer> Delete(int id);
    Task<Offer> Clone(int id);
    
    // TODO: Download
    // TODO: ReadFile
    // TODO: GetFileStructure
} 