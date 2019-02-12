using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acrs.Serverless.Common.Logging
{
    public class LogFactory
    {
        public static ILogger GetLogger(LoggerType loggerType = LoggerType.Console)
        {
            LoggerFactory factory = new LoggerFactory();
            var logger = factory.CreateLogger("Application");

            switch (loggerType)
            {
                case LoggerType.Console:
                    return new ConsoleLogger();
                default:
                    throw new NotImplementedException($"Logger of type {nameof(logger)} is not configuered.");
            }
        }
    }

    public enum LoggerType
    {
        Console = 1
    }
}
