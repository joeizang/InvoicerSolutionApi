using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class UserInvoiceTypeConfiguration : IEntityTypeConfiguration<UserInvoice>
{
    public void Configure(EntityTypeBuilder<UserInvoice> builder)
    {
        builder.HasMany(x => x.InvoiceItems)
            .WithOne(x => x.UserInvoice!)
            .HasForeignKey(x => x.UserInvoiceId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.User)
            .WithMany(a => a.UserInvoices)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.OwnsOne(x => x.DiscountAmount, y =>
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
        builder.OwnsOne(x => x.TotalInvoicedAmount, y =>
        {
            y.Property(x => x.Amount)
                .HasPrecision(2)
                .IsRequired();
            y.Property(x => x.Currency).IsRequired();
        });
        
        builder.Property(x => x.InvoiceRecipient)
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.InvoiceNumber)
            .HasMaxLength(70)
            .IsRequired();
        builder.Property(x => x.InvoiceRecipientEmail)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.InvoiceRecipientPhoneNumber)
            .HasMaxLength(33)
            .IsRequired(false);
        builder.Property(x => x.InvoiceRecipientAddress)
            .HasMaxLength(500)
            .IsRequired();
        builder.Property(x => x.InvoiceSpecialNote)
            .HasMaxLength(500)
            .IsRequired(false);
    }
}