using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class PlatformServiceTypeConfiguration : IEntityTypeConfiguration<PlatformService>
{
    public void Configure(EntityTypeBuilder<PlatformService> builder)
    {
        builder.OwnsOne(x => x.Price, build =>
        {
            build.Property(x => x.Amount).HasPrecision(2);
        });
        
        builder.HasOne(x => x.PlatformInvoice)
            .WithMany(x => x.PlatformServices)
            .HasForeignKey(x => x.PlatformInvoiceId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(x => x.Description)
            .HasMaxLength(500)
            .IsRequired(false);
        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.HasIndex(x => x.Name).IsUnique();
        builder.HasKey(x => x.Id);
    }
}