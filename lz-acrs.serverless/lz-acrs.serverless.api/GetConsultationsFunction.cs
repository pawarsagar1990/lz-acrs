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
using Newtonsoft.Json;

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
            try
            {
                _logger.LogInformation($"recieved request {request.Body}");

                var requestHandler = new GetConsultationsRequestHandler();

                var response = await requestHandler.HandleRequest(null);

                if (response != null)
                {
                    Console.WriteLine($"recieved response {JsonConvert.SerializeObject(response)}");

                    return CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    return CreateResponse(HttpStatusCode.NotFound, null);
                }
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, ex);
            }

        }
    }
}
