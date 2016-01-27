using System;
using System.Collections.Generic;

namespace EnterpriseSystems.Infrastructure.Model.Entities
{
    public class AppointmentVO
    {
        public AppointmentVO()
        {
            this.Status = "PENDING";
            this.RecordStatus = "A";
            this.CreatedDate = DateTime.Now;
            this.LastUpdatedDate = DateTime.Now;
            CustomerRequest = new CustomerRequestVO();
            Stop = new StopVO();
        }

        public int Identity { get; set; }
        public string EntityName { get; set; }
        public int EntityIdentity { get; set; }
        public int? SequenceNumber { get; set; }
        public string FunctionType { get; set; }
        public DateTime AppointmentBegin { get; set; }
        public DateTime AppointmentEnd { get; set; }
        public string TimezoneDescription { get; set; }
        public string Status { get; set; }
        public string RecordStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedProgramCode { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public string LasUpdatedProgramCode { get; set; }

        public CustomerRequestVO CustomerRequest { get; set; }
        public StopVO Stop { get; set; }
    }
}
