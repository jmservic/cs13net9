using Microsoft.EntityFrameworkCore; // To use UseSqlite.
using Microsoft.Extensions.DependencyInjection; // To use IServiceCollection.

namespace Northwind.EntityModels;

public static class NorthwindContextExtensions
{
    /// <summary>
    /// Adds NorthwindContext to the specified IServiceCollection. Uses the Sqlite database provider.
    /// </summary>
    /// <param name="services">The service colection.</param>
    /// <param name="relativePath">Default is ".."</param>
    /// <param name="databaseName">Default is "Northwind.db"</param>
    /// <returns>An IServiceCollection that can be used to add more services.</returns>
    public static IServiceCollection AddNorthwindContext(
        this IServiceCollection services, // The type to extend.
        string relativPath = "..",
        string databaseName = "Northwind.db")
    {
        string path = Path.Combine(relativPath, databaseName);
        path = Path.GetFullPath(path);
        NorthwindContextLogger.WriteLine($"Database path: {path}");

        if (!File.Exists(path))
        {
            throw new FileNotFoundException(
                message: $"{path} not found.", fileName: path
            );
        }

        services.AddDbContext<NorthwindContext>(options =>
        {
           // Data Source is the modern equivalent of Filename.
           options.UseSqlite($"Data Source={path}");

           options.LogTo(NorthwindContextLogger.WriteLine,
           [Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting]);
        },
           // Register with a transient lifetime to avoid concurrency issues in Blazore server-side projects.
           contextLifetime: ServiceLifetime.Transient,
           optionsLifetime: ServiceLifetime.Transient
        ); 

        return services;
    }


}
