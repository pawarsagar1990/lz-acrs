using Acrs.Serverless.Common.Logging;
using Acrs.Serverless.Models;
using Acrs.Serverless.Repositories;
using Acrs.Serverless.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acrs.Serverless.Services.Impl
{
    public class ConsultationService : IConsultationService
    {
        private readonly IConsultationRepository _consultationRespository;
        private readonly ILogger _logger;

        public ConsultationService()
        {
            _consultationRespository = new ConsultationRespository();
            _logger = LogFactory.GetLogger();
        }

        public async Task<Consultation> GetConsultation(string orderNumber)
        {
            _logger.LogInformation($"request data from repository for {orderNumber}"); 
            return await _consultationRespository.GetConsultation(orderNumber);
        }

        public async Task<IList<Consultation>> GetConsultations()
        {
            _logger.LogInformation($"inside {nameof(ConsultationService)} method {nameof(GetConsultations)}");

            return await _consultationRespository.GetConsultations();
        }
    }
}
