using Acrs.Serverless.Common.Handlers;
using Acrs.Serverless.Dto;
using Acrs.Serverless.Services;
using Acrs.Serverless.Services.Impl;
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
            var consultations = await _consultationService.GetConsultations();

            return new GetConsultationListResponse
            {
                Consultations = consultations
            };
        }
    }
}
