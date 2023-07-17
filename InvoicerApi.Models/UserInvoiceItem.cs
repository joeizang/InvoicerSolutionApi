using InvoicerApi.Kernel;

namespace InvoicerApi.Models;

public class UserInvoiceItem : BaseModel
{
    public string Name { get; set; }

    public string Description { get; set; }

    public double Quantity { get; set; }

    public Money Amount { get; set; }

    public UserInvoice UserInvoice { get; set; }

    public Guid UserInvoiceId { get; set; }
}