using InvoicerApi.Data.TypeConfiguration;
using InvoicerApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvoicerApi.Data;

public class InvoicerApiContext : IdentityDbContext<ApplicationUser>
{
    public InvoicerApiContext(DbContextOptions<InvoicerApiContext> options) : base(options)
    {
        
    }

    public InvoicerApiContext() : base()
    {
        
    }

    public InvoicerApiContext(DbContextOptionsBuilder<InvoicerApiContext> optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(PlatformInvoiceTypeConfiguration).Assembly);
        base.OnModelCreating(builder);
    }

    public DbSet<Address> Addresses { get; set; } = default!;
    
    public DbSet<UserInvoice> UserInvoices { get; set; } = default!;
    
    public DbSet<UserInvoiceItem> UserInvoiceItems { get; set; } = default!;
    
    public DbSet<PlatformInvoice> PlatformInvoices { get; set; } = default!;
    
    public DbSet<PlatformService> PlatformServices { get; set; } = default!;
    
}