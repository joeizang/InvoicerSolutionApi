using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class PlatformInvoice : BaseModel
{
    public string Name { get; set; }

    public string PlatformInvoiceNumber { get; set; }

    public DateTimeOffset InvoiceIssueDate { get; set; }

    public string Description { get; set; }

    public double Quantity { get; set; }

    public Money TotalSum { get; set; }

    public bool IsTaxable { get; set; }
    
    public Money TaxAmount { get; set; }

    public TaxType TaxCategory { get; set; }

    public bool OfferDiscount { get; set; }
    
    public Money DiscountAmount { get; set; }

    public InvoiceStatus PlatformInvoiceStatus { get; set; }

    public List<PlatformService> PlatformServices { get; set; }
    
    public ApplicationUser User { get; set; }
    
    public Guid UserId { get; set; }

    public PlatformInvoice()
    {
        PlatformServices = new List<PlatformService>();
    }
    
}