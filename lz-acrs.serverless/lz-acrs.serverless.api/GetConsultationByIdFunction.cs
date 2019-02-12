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

namespace Acrs.Serverless.Application
{
    public class GetConsultationByIdFunction : BaseFunction
    {
        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public GetConsultationByIdFunction() : base()
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
                var getByIdRequest = new GetConsultationByIdRequest
                {
                    OrderNumber = request.PathParameters["orderNumber"]
                };

                var requestHandler = new GetConsultationByIdRequestHandler();

                var response = await requestHandler.HandleRequest(getByIdRequest);

                Console.WriteLine($"recieved response {JsonConvert.SerializeObject(response)}");

                return new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(response),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
                };

            }
            catch (Exception ex)
            {
                return new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    Body = JsonConvert.SerializeObject(ex)
                };
            }

        }
    }
}
