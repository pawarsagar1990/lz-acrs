using System;

namespace Acrs.Serverless.Models
{
    public class Consultation
    {
        public string OrderNumber { get; set; }
        public DateTime SubmitDateUtc { get; set; }
        public DateTime? FirmAppointmentDate { get; set; }
        public DateTime CustomerAppointmentDate { get; set; }
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
