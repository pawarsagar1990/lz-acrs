using Acrs.Serverless.Models;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
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
            var conditions = new List<ScanCondition>();

            return await Context.ScanAsync<Consultation>(conditions).GetRemainingAsync();
        }

        public async Task<Consultation> GetConsultation(string id)
        {
            return await Context.LoadAsync<Consultation>(id);
        }
    }
}
