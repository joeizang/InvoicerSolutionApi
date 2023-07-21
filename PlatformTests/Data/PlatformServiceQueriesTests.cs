using InvoicerApi.Data;
using InvoicerApi.Kernel;
using InvoicerApi.Models;
using InvoicerApi.Models.ApiModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace PlatformTests.Data;

public class PlatformServiceQueriesTests
{
    public DbContextOptions<InvoicerApiContext> Options { get; set; }

    public InvoicerApiContext Context { get; set; }

    public PlatformServiceQueriesTests()
    {
        

    }
    [Fact]
    public async Task GetPlatformServicesAsync_ReturnsListOfPlatformServiceApiModel()
    {
        var platformServices = new System.Collections.Generic.List<PlatformService>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Description = "Test",
                Price = new Money(100m, Currency.Naira),
                PlatformInvoiceId = Guid.NewGuid()
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Test1",
                Description = "Test1",
                Price = new Money(200m, Currency.Naira),
                PlatformInvoiceId = Guid.NewGuid()
            }
        };
        var results = new List<PlatformServiceApiModel>();
        Options = new DbContextOptionsBuilder<InvoicerApiContext>()
            .UseSqlite("Data Source=:memory:")
            .Options;

        await using var context = new InvoicerApiContext(Options);
        context.Database.OpenConnection();
        await context.Database.EnsureDeletedAsync().ConfigureAwait(false);
        context.Database.EnsureCreated();
        // context.Database.Migrate();
        platformServices.ForEach(p => context.PlatformServices.Add(p));
        context.SaveChanges();

        // await foreach(var service in PlatformServiceQueries.GetPlatformServices(context))
        // {
        //     results.Add(service);
        // }
        //
        //
        // Assert.IsAssignableFrom<IEnumerable<PlatformServiceApiModel>>(results);
        // Assert.NotEmpty(results);
        // await context.Database.EnsureDeletedAsync().ConfigureAwait(false);
    }
}