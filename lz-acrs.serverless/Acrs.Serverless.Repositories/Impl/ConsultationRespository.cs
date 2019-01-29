using Acrs.Serverless.Models;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acrs.Serverless.Repositories.Impl
{
    public class ConsultationRespository : BaseRepository, IConsultationRepository
    {

        public ConsultationRespository()
            : base()
        {
            var tableName = nameof(Consultation);

            if (!string.IsNullOrEmpty(tableName))
            {
                AWSConfigsDynamoDB.Context.TypeMappings[typeof(Consultation)] = new Amazon.Util.TypeMapping(typeof(Consultation), tableName);
            }
        }

        public IList<Consultation> GetConsultations()
        {
            return Context
        }
    }
}
