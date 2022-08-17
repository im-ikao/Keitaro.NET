using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators.OAuth;

namespace Keitaro.NET.Http
{
    public interface IConnection
    {
        public RestClient Client { get; }
        public Task<RestResponse> ExecuteRaw(string endpoint, IList<Parameter> parameters, object data = null, Method method = Method.Get);
        public Task<T> ExecuteRequest<T>(string endpoint, IList<Parameter> parameters, object data = null, string expectedRoot = null, Method method = Method.Get) where T : new();
    }
}