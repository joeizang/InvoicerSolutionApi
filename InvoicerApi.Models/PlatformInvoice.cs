using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class PlatformInvoice : BaseModel
{
    public string Name { get; set; } = string.Empty;

    public string PlatformInvoiceNumber { get; set; } = string.Empty;

    public DateTimeOffset InvoiceIssueDate { get; set; }

    public string Description { get; set; } = string.Empty;

    public double Quantity { get; set; }

    public Money TotalSum { get; set; } = new Money(0m, Currency.Naira);

    public bool IsTaxable { get; set; }
    
    public Money TaxAmount { get; set; } = new Money(0m, Currency.Naira);

    public TaxType TaxCategory { get; set; }

    public bool OfferDiscount { get; set; }
    
    public Money DiscountAmount { get; set; } = new Money(0m, Currency.Naira);

    public InvoiceStatus PlatformInvoiceStatus { get; set; }

    public List<PlatformService> PlatformServices { get; set; }
    
    public ApplicationUser User { get; set; } = default!;
    
    public string UserId { get; set; }

    public PlatformInvoice()
    {
        PlatformServices = new List<PlatformService>();
    }
    
}