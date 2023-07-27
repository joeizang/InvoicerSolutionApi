using InvoicerApi.Models.ApiModels;
using Microsoft.EntityFrameworkCore;

namespace InvoicerApi.Data.CompiledQueries;

public class UserInvoiceQueries
{
    public static readonly Func<InvoicerApiContext, int, int, string, IAsyncEnumerable<UserInvoiceApiModel>>
        GetUserInvoicesByUserId =
            EF.CompileAsyncQuery(
                (InvoicerApiContext context, int pageSize, int pageNumber, string userId) =>
                    context.UserInvoices.AsNoTracking()
                        .Where(x => x.UserId.Equals(userId))
                        .OrderBy(x => x.InvoiceDate)
                        .Skip(pageSize * (pageNumber - 1))
                        .Take(10)
                        .Select(x => new UserInvoiceApiModel(x.Id, x.UserId,
                                x.InvoiceItems.Select(p => 
                                    new UserInvoiceItemApiModel(p.Id, p.Name, p.Description, p.Quantity, p.Amount)),
                                x.InvoiceDate, x.InvoiceRecipient, x.InvoiceRecipientAddress,
                                x.InvoiceRecipientEmail, x.InvoiceSpecialNote, x.InvoiceStatus, x.InvoiceType,
                                x.TaxCategory, x.TaxAmount, x.TotalInvoicedAmount, x.DiscountValue, x.InvoiceNumber))
            );
}