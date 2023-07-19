using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class UserInvoiceItem : BaseModel
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public double Quantity { get; set; }

    public Money Amount { get; set; } = new Money(0m, Currency.Naira);

    public UserInvoice UserInvoice { get; set; } = default!;

    public Guid UserInvoiceId { get; set; }
}