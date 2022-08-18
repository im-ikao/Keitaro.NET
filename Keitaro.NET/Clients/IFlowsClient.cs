using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;
using Flow = Keitaro.NET.Models.Responses.Flow;

namespace Keitaro.NET.Clients;

public interface IFlowsClient
{
    Task<IReadOnlyList<Flow>> GetAll(int campaignId);
    Task<IReadOnlyList<FlowFilter>> GetAvailableFilters();
    Task<IReadOnlyList<FlowParameter>> GetAvailableSchemas();
    Task<IReadOnlyList<FlowParameter>> GetTypes();
    Task<IReadOnlyList<FlowParameter>> GetActions();
    Task<Flow> Create(Models.Requests.Flow flow);
    Task<Flow> Get(int id);
    Task<Flow> Update(int id, Models.Requests.Flow flow);
    Task<Flow> Delete(int id);
    Task<Flow> Enable(int id);
    Task<Flow> Disable(int id);
    Task<Flow> GetEvents(int id);
    Task<Flow> Restore(int id);
    Task<IReadOnlyList<Flow>> GetAllDeleted();
    Task<IReadOnlyList<Flow>> Find(string query);
}