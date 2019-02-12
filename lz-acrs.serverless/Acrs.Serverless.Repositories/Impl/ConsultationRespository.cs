using Acrs.Serverless.Models;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IList<Consultation>> GetConsultations()
        {
            _logger.LogInformation("fetching consultation details");
            var conditions = new List<ScanCondition>();

            return await Context.ScanAsync<Consultation>(conditions).GetRemainingAsync();
        }

        public async Task<Consultation> GetConsultation(string orderNumber)
        {
            var conditions = new List<ScanCondition>
            {
                new ScanCondition("OrderNumber", ScanOperator.Equal, orderNumber)
            };
            var allMatchingConsultations = await Context.ScanAsync<Consultation>(conditions).GetRemainingAsync();

            return allMatchingConsultations.FirstOrDefault();
        }
    }
}
