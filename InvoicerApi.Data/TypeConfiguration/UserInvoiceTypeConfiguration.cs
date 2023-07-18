using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class UserInvoiceTypeConfiguration : IEntityTypeConfiguration<UserInvoice>
{
    public void Configure(EntityTypeBuilder<UserInvoice> builder)
    {
        throw new NotImplementedException();
    }
}