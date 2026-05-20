using Microsoft.EntityFrameworkCore;

public static class DatabaseConfig
{
    public static IServiceCollection AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
        }
        
        services.AddDbContext<Model.Context.SQLContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        return services;
    }
}