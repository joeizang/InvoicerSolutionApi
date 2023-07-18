using InvoicerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoicerApi.Data.TypeConfiguration;

public class PlatformServiceTypeConfiguration : IEntityTypeConfiguration<PlatformService>
{
    public void Configure(EntityTypeBuilder<PlatformService> builder)
    {
        throw new NotImplementedException();
    }
}