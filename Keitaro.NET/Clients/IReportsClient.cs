using Keitaro.NET.Models.Requests;
using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface IReportsClient
{
    /// <summary>
    /// Retrieve custom reports
    /// </summary>
    Task<Report> GetCustomReport(CustomReportSettings settings);
    
    /// <summary>
    /// Get labels
    /// </summary>
    Task<Success> GetLabels(int campaignId, string labelName, string refName);
    
    /// <summary>
    /// Update labels
    /// </summary>
    Task<Success> UpdateLabels(Label label);
}