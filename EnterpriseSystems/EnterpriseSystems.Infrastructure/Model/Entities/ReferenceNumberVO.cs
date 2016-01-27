using System;

namespace EnterpriseSystems.Infrastructure.Model.Entities
{
    public class ReferenceNumberVO
    {
        public ReferenceNumberVO()
        {
            this.RecordStatus = 'A';
            this.CreatedDate = DateTime.Now;
            this.LastUpdatedDate = DateTime.Now;
            this.CustomerRequest = new CustomerRequestVO();
        }
        public int Identity { get; set; }
        public string EntityName { get; set; }
        public int EntityIdentity { get; set; }
        public string SoutheasternReferenceNumberType { get; set; }
        public string ReferenceNumber { get; set; }
        public char RecordStatus { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedProgramCode { get; set; }

        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public string LastUpdatedProgramCode { get; set; }

        public CustomerRequestVO CustomerRequest { get; set; }
    }
}
