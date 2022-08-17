using System.Collections.ObjectModel;
using Keitaro.NET.Extensions;
using Newtonsoft.Json;
using RestSharp;

namespace Keitaro.NET.Http
{
    public class Connection : IConnection
    {
        public Connection(RestClient client)
        {
            Client = client;
        }

        #region IConnection Members

        public RestClient Client { get; private set; }
        
        public async Task<RestResponse> ExecuteRaw(string endpoint, IList<Parameter> parameters,
            object data = null, Method method = Method.Get)
        {
            var request = BuildRequest(endpoint, parameters);
            request.Method = method;

            if (data != null && method != Method.Get)
            {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(data);
            }

            return await Client.ExecuteTaskRaw(request).ConfigureAwait(false);
        }

        public async Task<T> ExecuteRequest<T>(string endpoint, IList<Parameter> parameters,
            object data = null, string expectedRoot = null, Method method = Method.Get)
            where T : new()
        {
            var request = BuildRequest(endpoint, parameters);
            request.RootElement = expectedRoot;
            request.Method = method;

            if (data != null && method != Method.Get)
            {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(data);
            }

            return await Client.ExecuteTask<T>(request).ConfigureAwait(false);
        }

        #endregion

        private RestRequest BuildRequest(string endpoint, IEnumerable<Parameter> parameters)
        {
            var request = new RestRequest(endpoint);

            if (parameters == null)
            {
                return request;
            }

            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter);
            }

            return request;
        }
    }
}