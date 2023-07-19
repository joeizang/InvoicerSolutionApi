using dotenv.net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InvoicerApi.Data;

public static class AddDbLayer
{
    public static void LightUpDataLayer(this IServiceCollection services, IConfiguration config)
    {
        DotEnv.Load();
        var connectionString = config.GetConnectionString("MYSQL_CONNECTION_STRING") ?? string.Empty;
        services.AddDbContextPool<InvoicerApiContext>(options =>
        {
            options.UseMySQL(connectionString);
        });
    }
}