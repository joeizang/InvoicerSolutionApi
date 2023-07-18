using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class UserInvoiceItemTypeConfiguration : IEntityTypeConfiguration<UserInvoiceItem>
{
    public void Configure(EntityTypeBuilder<UserInvoiceItem> builder)
    {
        throw new NotImplementedException();
    }
}