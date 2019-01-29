using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Serialization.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Acrs.Serverless.Common.Response
{
    public class ApiGatewayResponse : APIGatewayProxyResponse
    {
        public ApiGatewayResponse() : base()
        {

        }

        public ApiGatewayResponse(HttpStatusCode httpStatusCode, object body, IDictionary<string, string> headers = null)
            : base()
        {

            this.StatusCode = (int)httpStatusCode;
            this.Body = body.ToString();
            this.Headers = GetHeaders(headers);
        }

        private IDictionary<string, string> GetHeaders(IDictionary<string, string> headers)
        {
            headers = headers ?? new Dictionary<string, string>();

            headers.Add("Content-Type", "text/json");

            return headers;
        }


    }
}
