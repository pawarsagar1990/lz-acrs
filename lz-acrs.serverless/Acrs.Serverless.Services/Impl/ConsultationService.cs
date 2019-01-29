using Acrs.Serverless.Repositories;
using Acrs.Serverless.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acrs.Serverless.Services.Impl
{
    public class ConsultationService : IConsultationService
    {
        private readonly IConsultationRepository _consultationRespository;

        public ConsultationService()
        {
            _consultationRespository = new ConsultationRespository();
        }
    }
}
