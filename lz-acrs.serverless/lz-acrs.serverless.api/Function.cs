using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Acrs.Serverless.Common;
using Acrs.Serverless.Common.Response;
using Acrs.Serverless.Handlers.Impl;
using Acrs.Serverless.Dto;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Acrs.Serverless.Application
{
    public class GetConsultationsFunction : BaseFunction
    {
        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public GetConsultationsFunction() : base()
        {

        }


        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The list of blogs</returns>
        public override async Task<APIGatewayProxyResponse> ExecuteAsync(APIGatewayProxyRequest request, ILambdaContext context)
        {
            context.Logger.LogLine("Get Request\n");

            var requestHandler = new GetConsultationRequestHandler();

            var response = await requestHandler.HandleRequest(this.DeserializeObject<GetConsultationListRequest>(request.Body));

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = this.SerializeObject(response)
            };
        }
    }
}
