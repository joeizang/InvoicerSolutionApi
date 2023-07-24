using InvoicerApi.Models.ApiModels;
using Microsoft.EntityFrameworkCore;

namespace InvoicerApi.Data;

public static class PlatformServiceQueries
{

    public static readonly Func<InvoicerApiContext, IAsyncEnumerable<PlatformServiceApiModel>>
        GetPlatformServices =
            EF.CompileAsyncQuery(
                (InvoicerApiContext context) =>
                    context.PlatformServices.AsNoTracking()
                        .OrderBy(x => x.Name)
                        .Select(x =>
                            new PlatformServiceApiModel(x.Name, Guid.NewGuid(), x.Price, x.Description)));

    public static readonly Func<InvoicerApiContext, Guid, PlatformServiceApiModel?> GetPlatformService =
            EF.CompileQuery(
                (InvoicerApiContext context, Guid id) =>
                    context.PlatformServices.AsNoTracking()
                        .Where(x => x.Id == id)
                        .Select(x => new PlatformServiceApiModel(x.Name, x.Id, x.Price, x.Description))
                        .SingleOrDefault());
}
