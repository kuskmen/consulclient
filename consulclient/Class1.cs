namespace consulclient
{
    using consul.core;
    using System;
    using consul.core.Models;
    using Polly;
    using System.Threading.Tasks;

    public class ConsulClient : IConsulClient
    {
        public TResponse Call<TRequest, TResponse>(TRequest request, Policy recoverPolicy = null)
            where TRequest : class
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public TResponse Call<TRequest, TResponse>(TRequest request, RequestContext requestContext, Policy recoveryPolicy = null)
            where TRequest : class
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CallAsync<TRequest, TResponse>(TRequest request, Policy recoveryPolicy = null)
            where TRequest : class
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> CallAsync<TRequest, TResponse>(TRequest request, RequestContext requestContext, Policy recoveryPolicy = null)
            where TRequest : class
            where TResponse : class
        {
            throw new NotImplementedException();
        }
    }
}
