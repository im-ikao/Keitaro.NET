using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IClicksClient
{
    /// <summary>
    /// Retrieve a list of all clicks in your account
    /// </summary>
    Task<IReadOnlyList<Report>> GetAll(ReportSettings reportSettingsSettings);
    
    /// <summary>
    /// Update click costs in your account
    /// </summary>
    Task<Success> UpdateCosts(ClickCost costs);
}