namespace consul.core.Extenders
{
    public interface IClientExtender
    {
        void PreProcessing<TRequest>(TRequest request) where TRequest : class;

        void PostProcessing<TRequest, TResponse>(TRequest request, TResponse response)
            where TRequest : class
            where TResponse : class;
    }
}
