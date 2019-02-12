using System;

namespace Acrs.Serverless.Models
{
    public class Consultation
    {
        public string OrderNumber { get; set; }
        public string SubmitDateUtc { get; set; }
        public string FirmAppointmentDate { get; set; }
        public string CustomerAppointmentDate { get; set; }
        public string State { get; set; }
        public string Status { get; set; }

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Language { get; set; }
        public string Employer { get; set; }
        public string LegalMatter { get; set; }
        public string AttorneyAssigned { get; set; }
    }
}
