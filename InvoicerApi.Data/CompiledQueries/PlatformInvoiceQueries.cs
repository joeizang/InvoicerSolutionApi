using InvoicerApi.Kernel;
using InvoicerApi.Models;
using InvoicerApi.Models.ApiModels;
using Microsoft.EntityFrameworkCore;

namespace InvoicerApi.Data;

public class PlatformInvoiceQueries
{
    public static readonly Func<InvoicerApiContext, int, int, string, IAsyncEnumerable<PlatformInvoiceApiModel>>
      GetPlatformInvoicesByUserId =
        EF.CompileAsyncQuery(
            (InvoicerApiContext context, int pageSize, int pageNumber, string userId) =>
                context.PlatformInvoices.AsNoTracking()
                    .Include(x => x.PlatformServices)
                    .Include(x => x.User)
                    .Where(x => x.UserId.Equals(userId))
                    .OrderBy(x => x.InvoiceIssueDate)
                    .Skip(pageSize * (pageNumber - 1))
                    .Select(x => new PlatformInvoiceApiModel(x.Id, x.InvoiceIssueDate, x.TotalSum, 
                            x.TaxAmount, x.TaxCategory, x.DiscountAmount, x.PlatformInvoiceNumber,
                            x.PlatformInvoiceStatus, x.UserId, x.User.Email,
                            x.PlatformServices.Select(p => new PlatformServiceApiModel(p.Name, 
                                p.Id, p.Price, p.Description)
                      )
                      )
                    ).Take(10)
        );
    
    public static readonly Func<InvoicerApiContext, int, int, string, IAsyncEnumerable<PlatformInvoiceApiModel>>
      GetPlatformInvoicesByUserIdAndStatus =
        EF.CompileAsyncQuery(
            (InvoicerApiContext context, int pageSize, int pageNumber, string userId) =>
                context.PlatformInvoices.AsNoTracking()
                    .Where(x => x.UserId.Equals(userId) && x.PlatformInvoiceStatus == InvoiceStatus.Sent)
                    .OrderBy(x => x.InvoiceIssueDate)
                    .Select(x => new PlatformInvoiceApiModel(x.Id, x.InvoiceIssueDate, x.TotalSum,
                            x.TaxAmount, x.TaxCategory, x.DiscountAmount, x.PlatformInvoiceNumber,
                            x.PlatformInvoiceStatus, x.UserId, x.User.Email,
                            x.PlatformServices.Select(p => new PlatformServiceApiModel(p.Name,
                                p.Id, p.Price, p.Description)
                        )
                        )
                    ).Skip(pageSize * (pageNumber - 1))
                    .Take(pageSize)
        );
    
    public static readonly Func<InvoicerApiContext, int, int, string, decimal, IAsyncEnumerable<PlatformInvoiceApiModel>>
      GetPlatformInvoicesByUserIdAndStatusAndDate =
        EF.CompileAsyncQuery(
            (InvoicerApiContext context, int pageSize, int pageNumber, string userId, decimal totalAmount) =>
                context.PlatformInvoices.AsNoTracking()
                    .Where(x => x.UserId.Equals(userId) && x.PlatformInvoiceStatus == InvoiceStatus.Sent)
                    .OrderBy(x => x.InvoiceIssueDate)
                    .ThenBy(x => x.TotalSum.Amount)
                    .Select(x => new PlatformInvoiceApiModel(x.Id, x.InvoiceIssueDate, x.TotalSum, 
                            x.TaxAmount, x.TaxCategory, x.DiscountAmount, x.PlatformInvoiceNumber,
                            x.PlatformInvoiceStatus, x.UserId, x.User.Email,
                            x.PlatformServices.Select(p => new PlatformServiceApiModel(p.Name,
                                p.Id, p.Price, p.Description)
                        )
                        )
                    ).Skip(pageSize * (pageNumber - 1))
                    .Take(pageSize)
        );
}
