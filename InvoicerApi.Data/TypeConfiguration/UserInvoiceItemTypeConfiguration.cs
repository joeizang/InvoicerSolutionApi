using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class UserInvoiceItemTypeConfiguration : IEntityTypeConfiguration<UserInvoiceItem>
{
    public void Configure(EntityTypeBuilder<UserInvoiceItem> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(u => u.Description)
            .HasMaxLength(1000)
            .IsRequired(false);
        builder.Property(u => u.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.HasIndex(x => x.Name).IsUnique();
        builder.OwnsOne(u => u.Amount, build =>
        {
            build.Property(x => x.Amount)
                .HasPrecision(2);
            build.Property(x => x.Currency)
                .HasMaxLength(3)
                .IsFixedLength();
        });
    }
}