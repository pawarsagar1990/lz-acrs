using Acrs.Serverless.Common.Response;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.IO;
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

        }

        public virtual async Task<APIGatewayProxyResponse> ExecuteAsync(APIGatewayProxyRequest input, ILambdaContext context)
        {
            //context.Logger.Log(SerializeObject(input));
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

        public virtual async Task<ApiGatewayResponse> FunctionHandler(string message, ILambdaContext context)
        {
            //_logger?.LogInformation("Message: {@request}", message);

            return await Task.FromResult(new ApiGatewayResponse() { Body = "success" });
        }

        ~BaseFunction()
        {
            //_logger?.LogInformation("Shutting Down...");
            Dispose(false);
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            //_logger?.LogInformation("Shutting Down...");
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
    }
}
