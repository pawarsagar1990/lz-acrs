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
    public class GetConsultationByIdRequestHandler : RequestHandler<GetConsultationByIdResponse, GetConsultationByIdRequest>
    {
        private readonly IConsultationService _consultationService;
        private readonly ILogger _logger;

        public GetConsultationByIdRequestHandler()
        {
            _consultationService = new ConsultationService();
            _logger = LogFactory.GetLogger();
        }

        public async override Task<GetConsultationByIdResponse> HandleRequest(GetConsultationByIdRequest request)
        {
            _logger.LogInformation($"inside {nameof(GetConsultationByIdRequestHandler)}");

            var consultation = await _consultationService.GetConsultation(request.OrderNumber);

            var response = new GetConsultationByIdResponse
            {
                Consultation = consultation
            };

            _logger.LogInformation($"retrived {consultation} record");

            _logger.LogInformation($"completed {nameof(GetConsultationByIdRequestHandler)}");

            return response;
        }
    }
}
