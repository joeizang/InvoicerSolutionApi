using InvoicerApi.Kernel;

namespace InvoicerApi.Models.ApiModels;

public record PlatformInvoiceApiModel(Guid PlatformInvoiceId, DateTimeOffset InvoiceDate, Money TotalSum,
    Money TaxAmount, TaxType TaxCategory, Money DiscountAmount, string InvoiceNumber, InvoiceStatus Status,
    string UserId, string? UserEmail, IEnumerable<PlatformServiceApiModel> PlatformServices);
