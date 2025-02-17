using System.Collections.Generic;

namespace Data.Entities;

public class InvoiceStatusEntity
{
    public int Id { get; set; }
    public string? Status { get; set; } // Ex: Betald, Obetald
    public ICollection<InvoiceEntity> Invoices { get; set; } = null!;
}
