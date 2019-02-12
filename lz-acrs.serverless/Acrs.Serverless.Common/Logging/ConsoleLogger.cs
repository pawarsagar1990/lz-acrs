using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acrs.Serverless.Common.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void LogInformation(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }

    public interface ILogger
    {
        void LogInformation(string message, params object[] args);
    }
}
