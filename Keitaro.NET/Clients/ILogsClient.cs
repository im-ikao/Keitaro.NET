using Keitaro.NET.Models.Responses;

namespace Keitaro.NET.Clients;

public interface ILogsClient
{
    /// <summary>
    /// Retrieve a list of all logs by type in your account
    /// </summary>
    Task<Log> GetAll(LogType type);
    
    /// <summary>
    /// Clean a list of all logs by type in your account
    /// </summary>
    void Clean(LogType type);
}