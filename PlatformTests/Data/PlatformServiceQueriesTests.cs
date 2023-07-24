using InvoicerApi.Data;
using Microsoft.EntityFrameworkCore;

namespace PlatformTests.Data;

public class PlatformServiceQueriesTests
{

    [Fact]
    public void GetPlatformServicesAsync_ReturnsListOfPlatformServiceApiModel()
    {
        // var invoiceId = Guid.NewGuid();
        // var platformServices = new List<PlatformService>
        // {
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Test",
        //         Description = "Test",
        //         Price = new Money(100m, Currency.Naira),
        //         PlatformInvoiceId = invoiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Test1",
        //         Description = "Test1",
        //         Price = new Money(200m, Currency.Naira),
        //         PlatformInvoiceId = invoiceId
        //     }
        // };
        // PlatformInvoice platformInvoice = new()
        // {
        //     Name = "Test Platform Invoice",
        //     Description = "Test Description",
        //     InvoiceIssueDate = DateTimeOffset.UtcNow,
        //     PlatformInvoiceNumber = "Test12345",
        //     Quantity = 1,
        //     TaxCategory = TaxType.VAT,
        //     OfferDiscount = false,
        //     PlatformInvoiceStatus = InvoiceStatus.Draft,
        //     TotalSum = new Money(330m, Currency.Naira),
        //     TaxAmount = new Money(30m, Currency.Naira),
        //     DiscountAmount = new Money(0m, Currency.Naira),
        //     PlatformServices = platformServices,
        //     UserId = Guid.NewGuid().ToString(),
        //     Id = invoiceId,
        // };
        // var results = new List<PlatformServiceApiModel>();
        // var contextOptions = new DbContextOptionsBuilder<InvoicerApiContext>()
        //     .UseSqlite("Data Source=./testdb.sqlite")
        //     .Options;
        // using (var db = new InvoicerApiContext(contextOptions))
        // {
        //     try
        //     {
        //         db.PlatformInvoices.Add(platformInvoice);
        //         var result = await db.SaveChangesAsync();
        //         var getInvoices = db.PlatformInvoices.AsNoTracking()
        //             .Include(x => x.PlatformServices)
        //             .Count();
        //         var resultingCount = getInvoices;
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         throw;
        //     }
        // }
        
    }
}