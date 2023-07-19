using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class UserInvoice : BaseModel
{
    public string InvoiceNumber { get; set; } = string.Empty;

    public DateTimeOffset InvoiceDate { get; set; }

    public Money TotalInvoicedAmount { get; set; }

    public InvoiceStatus InvoiceStatus { get; set; }

    public InvoiceCategory InvoiceType { get; set; }

    public string InvoiceRecipient { get; set; } = string.Empty;

    public string InvoiceRecipientAddress { get; set; } = string.Empty;

    public string InvoiceRecipientEmail { get; set; } = string.Empty;
    
    public string InvoiceRecipientPhoneNumber { get; set; } = string.Empty;

    public string InvoiceSpecialNote { get; set; } = string.Empty;

    public bool IsTaxable { get; set; }
    
    public TaxType TaxCategory { get; set; }
    
    public Money TaxAmount { get; set; }

    public bool OfferDiscount { get; set; }

    public double DiscountValue { get; set; }
    
    public Money DiscountAmount { get; set; }

    public ICollection<UserInvoiceItem> InvoiceItems { get; set; }

    public ApplicationUser User { get; set; } = default!;
    
    public string UserId { get; set; }

    public UserInvoice()
    {
        InvoiceItems = new List<UserInvoiceItem>();
        TotalInvoicedAmount = new Money(0m, User.PreferredCurrency);
        TaxAmount = new Money(0m, User.PreferredCurrency);
        DiscountAmount = new Money(0m, User.PreferredCurrency);
    }
}
