using Acrs.Serverless.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acrs.Serverless.Repositories
{
    public interface IConsultationRepository
    {
        Task<IList<Consultation>> GetConsultations();

        Task<Consultation> GetConsultation(string id);
    }
}
