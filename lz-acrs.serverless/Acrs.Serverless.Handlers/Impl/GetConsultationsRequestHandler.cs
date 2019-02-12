using Acrs.Serverless.Common.Handlers;
using Acrs.Serverless.Common.Logging;
using Acrs.Serverless.Dto;
using Acrs.Serverless.Services;
using Acrs.Serverless.Services.Impl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Acrs.Serverless.Handlers.Impl
{
    public class GetConsultationsRequestHandler : RequestHandler<GetConsultationListResponse, GetConsultationListRequest>
    {
        private readonly IConsultationService _consultationService;
        private readonly ILogger _logger;

        public GetConsultationsRequestHandler()
        {
            _consultationService = new ConsultationService();
            _logger = LogFactory.GetLogger();
        }

        public async override Task<GetConsultationListResponse> HandleRequest(GetConsultationListRequest request)
        {
            _logger.LogInformation($"inside {nameof(GetConsultationsRequestHandler)}");

            var consultations = await _consultationService.GetConsultations();

            var response = new GetConsultationListResponse
            {
                Consultations = consultations
            };

            _logger.LogInformation($"retrived {consultations.Count} records");

            _logger.LogInformation($"completed {nameof(GetConsultationsRequestHandler)}");

            return response;
        }
    }
}
