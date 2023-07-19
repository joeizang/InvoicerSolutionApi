using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class PlatformInvoiceTypeConfiguration : IEntityTypeConfiguration<PlatformInvoice>
{
    public void Configure(EntityTypeBuilder<PlatformInvoice> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.PlatformInvoiceNumber)
            .HasMaxLength(64)
            .IsRequired();
        builder.Property(x => x.InvoiceIssueDate).IsRequired();
        builder.Property(x => x.Description)
            .HasMaxLength(1000)
            .IsRequired(false);
        builder.Property(x => x.Quantity).IsRequired();
        
        builder.OwnsOne(x => x.TotalSum, y =>
        {
            y.Property(x => x.Amount)
                .HasPrecision(2)
                .IsRequired();
            y.Property(x => x.Currency).IsRequired();
        });
        
        builder.OwnsOne(x => x.TaxAmount, y =>
        {
            y.Property(x => x.Amount)
                .HasPrecision(2)
                .IsRequired();
            y.Property(x => x.Currency).IsRequired();
        });
        builder.Property(x => x.TaxCategory).IsRequired();
        builder.Property(x => x.OfferDiscount).IsRequired();

        builder.OwnsOne(x => x.DiscountAmount, y =>
        {
            y.Property(x => x.Amount)
                .HasPrecision(2)
                .IsRequired();
            y.Property(x => x.Currency).IsRequired();
        });
        builder.Property(x => x.PlatformInvoiceStatus).IsRequired();
        builder.HasMany(x => x.PlatformServices)
            .WithOne(x => x.PlatformInvoice)
            .HasForeignKey(x => x.PlatformInvoiceId);
        builder.HasOne(x => x.User)
            .WithMany(x => x.PlatformInvoices)
            .HasForeignKey(x => x.UserId);
    }
}