using Acrs.Serverless.Common.Handlers;
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
    public class GetConsultationRequestHandler : RequestHandler<GetConsultationListResponse, GetConsultationListRequest>
    {
        private readonly IConsultationService _consultationService;

        public GetConsultationRequestHandler()
        {
            _consultationService = new ConsultationService();
        }

        public async override Task<GetConsultationListResponse> HandleRequest(GetConsultationListRequest request)
        {
            Console.WriteLine($"inside {nameof(GetConsultationRequestHandler)}");

            var consultations = await _consultationService.GetConsultations();

            Console.WriteLine($"completed {nameof(GetConsultationRequestHandler)}");

            var response = new GetConsultationListResponse
            {
                Consultations = consultations
            };

            Console.WriteLine($"completed {JsonConvert.SerializeObject(response)}");

            return response;
        }
    }
}
