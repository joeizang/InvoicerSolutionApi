using InvoicerApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvoicerApi.Data;

public class InvoicerApiContext : IdentityDbContext<ApplicationUser>
{
    public InvoicerApiContext(DbContextOptions<InvoicerApiContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Address> Addresses { get; set; } = default!;
    
    public DbSet<UserInvoice> UserInvoices { get; set; } = default!;
    
    public DbSet<UserInvoiceItem> UserInvoiceItems { get; set; } = default!;
    
    public DbSet<PlatformInvoice> PlatformInvoices { get; set; } = default!;
    
    public DbSet<PlatformService> PlatformServices { get; set; } = default!;
    
}