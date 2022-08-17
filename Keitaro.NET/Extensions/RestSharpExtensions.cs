using System.Collections.ObjectModel;
using System.Net;
using Keitaro.NET.Exceptions;
using Keitaro.NET.Models.Responses;
using Newtonsoft.Json;
using RestSharp;

namespace Keitaro.NET.Extensions
{
 public static class RestSharpExtensions {
        public static async Task<T> ExecuteTask<T>(this RestClient client, RestRequest request)
            where T : new() {
            var ret = await GetResponseContentAsync(client, request);
            return JsonConvert.DeserializeObject<T>(ret.ThrowIfException().Content);
        }

        public static async Task<RestResponse> ExecuteTaskRaw(this RestClient client, RestRequest request) {
            var ret = await GetResponseContentAsync(client, request);
            request.OnBeforeDeserialization(ret);
            return ret.ThrowIfException();
        }

        public static Task<IReadOnlyList<byte>> ToByteArrayAsync(this Task<RestResponse> task) {
            return task.ContinueWith(t => (IReadOnlyList<byte>) new ReadOnlyCollection<byte>(t.Result?.RawBytes ?? new byte[] { }));
        }

        private static RestResponse ThrowIfException(this RestResponse response) {
            if (response.ErrorException != null) {
                throw new Exception("There was an an exception thrown during the request.",
                    response.ErrorException);
            }

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new WebException();
            }

            if ((int) response.StatusCode >= 400) {
                throw new ApiException(response.StatusCode, JsonConvert.DeserializeObject<Error>(response.Content));
            }

            return response;
        }

        private static async Task<RestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest) {
            var response = await theClient.ExecuteAsync(theRequest);
            return response;
        }
        
    }   
}