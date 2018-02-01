namespace consul.core.Channels
{
    using consul.core.Models;
    using System;
    using System.Threading.Tasks;

    public interface IChannel : IDisposable
    {
        TResponse Call<TRequest, TResponse>(TRequest request, RequestContext microserviceExecutionContext)
            where TRequest : class
            where TResponse : class;

        Task<TResponse> CallAsync<TRequest, TResponse>(TRequest request, RequestContext microserviceExecutionContext)
            where TRequest : class 
            where TResponse : class;
    }
}