using InvoicerApi.Kernel;

namespace InvoicerApi.Models.ApiModels;

public record PlatformServiceApiModel(string Name, Guid PlatformServiceId, Money Price, string Description);