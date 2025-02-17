using System;

namespace Data.Entities
{
    public class InvoiceEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public int ProjectEntityId { get; set; }
        public ProjectEntity Project { get; set; }

        public int InvoiceStatusEntityId { get; set; }
        public InvoiceStatusEntity InvoiceStatus { get; set; }
    }
}
