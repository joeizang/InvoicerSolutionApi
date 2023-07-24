using InvoicerApi.Kernel;

namespace InvoicerApi.Models.ApiModels;

public record UserInvoiceApiModel(
    Guid InvoiceId, string UserId, IEnumerable<UserInvoiceItemApiModel> UserInvoiceItems, DateTimeOffset InvoiceIssueDate,
    string InvoiceRecipient, string InvoiceRecipientAddress, string InvoiceRecipientEmail, string InvoiceSpecialNote,
    InvoiceStatus InvoiceStatus, InvoiceCategory InvoiceType, TaxType TaxCategory, Money TaxAmount, Money TotalInvoicedAmount,
    double DiscountPercentage, string InvoiceNumber);