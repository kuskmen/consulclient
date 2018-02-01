namespace consul.core
{
    using consul.core.Models;
    using Polly;
    using System.Threading.Tasks;

    public interface IConsulClient
    {
        TResponse Call<TRequest, TResponse>(TRequest request, Policy recoverPolicy = null)
            where TRequest : class
            where TResponse : class;

        TResponse Call<TRequest, TResponse>(TRequest request, RequestContext requestContext, Policy recoveryPolicy = null)
           where TRequest : class
           where TResponse : class;

        Task<TResponse> CallAsync<TRequest, TResponse>(TRequest request, Policy recoveryPolicy = null)
            where TRequest : class
            where TResponse : class;

        Task<TResponse> CallAsync<TRequest, TResponse>(TRequest request, RequestContext requestContext, Policy recoveryPolicy = null)
            where TRequest : class
            where TResponse : class;
    }
}
