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

        public ConsultationService()
        {
            /// _consultationRespository = new ConsultationRespository();
        }

        public async Task<Consultation> GetConsultation(string id)
        {
            return await _consultationRespository.GetConsultation(id);
        }

        public async Task<IList<Consultation>> GetConsultations()
        {
            Console.WriteLine($"inside {nameof(ConsultationService)} method {nameof(GetConsultations)}");

            return await Task.FromResult(new List<Consultation> { new Consultation { CustomerFirstName = "Mandar" } });
        }
    }
}
