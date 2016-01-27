using System;

namespace EnterpriseSystems.Infrastructure.Model.Entities
{
    public class CommentVO
    {
        public CommentVO()
        {
            this.RecordStatus = 'A';
            this.CreatedDate = DateTime.Now;
            this.CreatedDate = DateTime.Now;
            this.CustomerRequest = new CustomerRequestVO();
            this.Stop = new StopVO();
        }
        public int Identity { get; set; }
        public string EntityName { get; set; }
        public int EntityIdentity { get; set; }
        public int? SequenceNumber { get; set; }
        public string CommentType { get; set; }
        public string CommentText { get; set; }
        public char RecordStatus { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedProgramCode { get; set; }

        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public string LastUpdatedProgramCode { get; set; }

        public CustomerRequestVO CustomerRequest { get; set; }
        public StopVO Stop { get; set; }
    }
}
