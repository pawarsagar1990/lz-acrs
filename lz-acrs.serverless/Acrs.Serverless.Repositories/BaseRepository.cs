using Acrs.Serverless.Common.Logging;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acrs.Serverless.Repositories
{
    public class BaseRepository
    {
        protected readonly IDynamoDBContext Context;
        protected readonly ILogger _logger;

        public BaseRepository()
        {
            var config = new DynamoDBContextConfig { Conversion = DynamoDBEntryConversion.V2 };
            Context = new DynamoDBContext(new AmazonDynamoDBClient(), config);

            _logger = LogFactory.GetLogger();
        }
    }
}
