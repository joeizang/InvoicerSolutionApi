using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class PlatformService : BaseModel
{
    public required string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    
    public double Quantity { get; set; }
    
    public Money Price { get; set; } = new Money(0m, Currency.Naira);

    public Guid PlatformInvoiceId { get; set; }
    
    public PlatformInvoice PlatformInvoice { get; set; } = default!;
}