using System.Threading.Tasks;

namespace Acrs.Serverless.Common.Handlers
{
    public interface IRequestHandler<TResponse, TRequest>
        where TResponse : new()
        where TRequest : new()
    {
        Task<TResponse> HandleRequest(TRequest request);
    }
}