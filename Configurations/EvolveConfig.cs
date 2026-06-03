using EvolveDb;
using MySqlConnector;
using Serilog;

namespace Configurations
{
    public static class EvolveConfig
    {
        public static IServiceCollection AddEvolve(
            this IServiceCollection services, 
            IConfiguration configuration,
            IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
                }

                try
                {
                    using var evolveConnection = new MySqlConnection(connectionString);
                    var evolve = new Evolve(evolveConnection, msg => Log.Information(msg))
                    {
                        Locations = new[] { "db/migrations", "db/dataset" },
                        IsEraseDisabled = true,
                    };
                    evolve.Migrate();
                }
                catch (Exception ex)
                {
                    Log.Error("Database migration failed: {Message}", ex.Message);
                    throw;
                }
            }

            return services;
        }
    }
}