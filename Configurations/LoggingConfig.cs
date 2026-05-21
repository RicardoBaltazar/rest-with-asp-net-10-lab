using Serilog;

namespace Configurations
{
    public static class LoggingConfig
    {
        public static void AddSerilog(this WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog((context, configuration) =>
            {
                configuration
                    .ReadFrom.Configuration(context.Configuration)
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.Debug();
            });
        }
    }
}