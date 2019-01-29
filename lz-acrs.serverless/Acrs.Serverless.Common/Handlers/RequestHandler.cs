using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acrs.Serverless.Common.Handlers
{
    public class RequestHandler<TResponse, TRequest> : IRequestHandler<TResponse, TRequest> where TResponse : new()
                                                                                            where TRequest : new()
    {
        public virtual async Task<TResponse> HandleRequest(TRequest request)
        {
            return await Task.FromResult<TResponse>(new TResponse());
        }
    }
}
