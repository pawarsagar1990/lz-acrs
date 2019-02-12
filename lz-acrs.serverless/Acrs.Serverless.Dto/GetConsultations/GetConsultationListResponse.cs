using Acrs.Serverless.Common.Response;
using Acrs.Serverless.Models;
using System;
using System.Collections.Generic;

namespace Acrs.Serverless.Dto
{
    public class GetConsultationListResponse
    {
        public IList<Consultation> Consultations { get; set; }
    }
}
