namespace consul.core.Channels
{
    using System.Threading.Tasks;
    using consul.core.Models;
    using System.Net.Http;

    public class HttpChannel : IChannel
    {
        private HttpClient _httpClient;

        public HttpChannel()
        {
            _httpClient = new HttpClient();
        }

        public TResponse Call<TRequest, TResponse>(TRequest request, RequestContext microserviceExecutionContext)
            where TRequest : class
            where TResponse : class
        {
            throw new System.NotImplementedException();
        }

        public Task<TResponse> CallAsync<TRequest, TResponse>(TRequest request, RequestContext microserviceExecutionContext)
            where TRequest : class
            where TResponse : class
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
