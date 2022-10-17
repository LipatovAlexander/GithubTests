using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GithubTests;

// ReSharper disable once UnusedType.Global
public sealed class Startup
{
    // ReSharper disable once UnusedMember.Global
    public static void ConfigureHost(IHostBuilder hostBuilder) =>
        hostBuilder
            .ConfigureHostConfiguration(builder =>
            {
                builder
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true)
                    .AddJsonFile("appsettings.Development.json", true)
                    .AddEnvironmentVariables();
            });
    
    // ReSharper disable once UnusedMember.Global
    public static void ConfigureServices(IServiceCollection services, HostBuilderContext context)
    {
        services.Configure<GithubOptions>(context.Configuration.GetSection("GitHub"));
    }
}