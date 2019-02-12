using Acrs.Serverless.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acrs.Serverless.Services
{
    public interface IConsultationService
    {
        Task<IList<Consultation>> GetConsultations();

        Task<Consultation> GetConsultation(string orderNumber);
    }
}
