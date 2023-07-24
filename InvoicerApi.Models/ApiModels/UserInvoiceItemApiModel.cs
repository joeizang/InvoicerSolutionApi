using InvoicerApi.Kernel;

namespace InvoicerApi.Models.ApiModels;

public record UserInvoiceItemApiModel(Guid Id, string Name, string Description, double Quantity, Money Amount);