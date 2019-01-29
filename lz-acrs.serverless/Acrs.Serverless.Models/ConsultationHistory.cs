using System;
using System.Collections.Generic;
using System.Text;

namespace Acrs.Serverless.Models
{
    public class ConsultationHistory
    {
        public string HistoryId { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime DateEntered { get; set; }
        public string Comment { get; set; }
    }
}
