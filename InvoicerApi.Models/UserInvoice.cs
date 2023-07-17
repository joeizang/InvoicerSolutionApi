using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class UserInvoice : BaseModel
{
    public string InvoiceNumber { get; set; }

    public DateTimeOffset InvoiceDate { get; set; }

    public decimal InvoicedAmount { get; set; }

    public InvoiceStatus InvoiceStatus { get; set; }

    public string InvoiceReceiptient { get; set; }

    public string InvoiceReceiptientAddress { get; set; }

    public string InvoiceReceiptientEmail { get; set; }

    public bool IsTaxable { get; set; }

    public bool OfferDiscount { get; set; }

    public double DiscountValue { get; set; }

    public ICollection<UserInvoiceItem> InvoiceItems { get; set; }
}