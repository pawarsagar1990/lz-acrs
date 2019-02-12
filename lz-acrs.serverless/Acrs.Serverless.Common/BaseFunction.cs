using Acrs.Serverless.Common.Logging;
using Acrs.Serverless.Common.Response;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Acrs.Serverless.Common
{
    public class BaseFunction : IDisposable
    {
        protected static IConfigurationRoot _configuration;

        protected ILogger _logger = null;


        public BaseFunction()
        {
            _logger = LogFactory.GetLogger();
        }

        public virtual async Task<APIGatewayProxyResponse> ExecuteAsync(APIGatewayProxyRequest input, ILambdaContext context)
        {
            _logger.LogInformation(SerializeObject(input));
            var response = new APIGatewayProxyResponse()
            {
                StatusCode = 200,
                Body = "success"
            };
            var message = input.Body;
            if (message == null)
                return null;

            try
            {
                response = await FunctionHandler(input.Body, context);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                //TODO: Do something here.
            }

            return response;
        }

        public virtual async Task<APIGatewayProxyResponse> FunctionHandler(string message, ILambdaContext context)
        {
            _logger.LogInformation("Message: {@request}", message);

            return await Task.FromResult(new APIGatewayProxyResponse() { Body = "success" });
        }

        ~BaseFunction()
        {
            _logger.LogInformation("Shutting Down...");
            Dispose(false);
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            _logger?.LogInformation("disposing...");
            if (!disposedValue)
            {
                if (disposing)
                {

                }

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(true);
        }

        protected string SerializeObject<T>(T objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
        }

        protected T DeserializeObject<T>(string serializedObject)
        {
            return JsonConvert.DeserializeObject<T>(serializedObject);
        }

        public APIGatewayProxyResponse CreateResponse(HttpStatusCode statusCode, object response)
        {
            return CreateResponse(statusCode, response, null);
        }

        public APIGatewayProxyResponse CreateResponse(HttpStatusCode statusCode, object response, IDictionary<string, string> headers)
        {
            headers = headers ?? new Dictionary<string, string>();
            headers.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = SerializeObject(response ?? new object()),
                Headers = headers
            };
        }
    }
}
