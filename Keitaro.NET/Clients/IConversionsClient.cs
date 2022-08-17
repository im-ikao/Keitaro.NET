using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IConversionsClient
{
    /// <summary>
    /// Retrieve a list of all conversions in your account
    /// </summary>
    Task<IReadOnlyList<Report>> GetAll(ReportSettings reportSettingsSettings);
}