using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class UserInvoice : BaseModel
{
    public string InvoiceNumber { get; set; } = string.Empty;

    public DateTimeOffset InvoiceDate { get; set; }

    public decimal TotalInvoicedAmount { get; set; }

    public InvoiceStatus InvoiceStatus { get; set; }

    public string InvoiceReceiptient { get; set; } = string.Empty;

    public string InvoiceReceiptientAddress { get; set; } = string.Empty;

    public string InvoiceReceiptientEmail { get; set; } = string.Empty;
    
    public string InvoiceReceiptientPhoneNumber { get; set; } = string.Empty;

    public string InvoiceSpecialNote { get; set; } = string.Empty;

    public bool IsTaxable { get; set; }
    
    public TaxType TaxCategory { get; set; }
    
    public Money TaxAmount { get; set; }

    public bool OfferDiscount { get; set; }

    public double DiscountValue { get; set; }
    
    public Money DiscountAmount { get; set; }

    public ICollection<UserInvoiceItem> InvoiceItems { get; set; }

    public ApplicationUser User { get; set; }
    
    public Guid UserId { get; set; }
}