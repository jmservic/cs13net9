using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

public partial class NorthwinContext : DbContext
{
    public NorthwinContext()
    {
    }

    public NorthwinContext(DbContextOptions<NorthwinContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string database = "Northwind.db";
            string dir = Environment.CurrentDirectory;
            string path = string.Empty;

            if (dir.EndsWith("net9.0"))
            {
                // In the <project>\bin\<Debug|Release>\net9.0 directory
                path = Path.Combine("..", "..", "..", "..", database);
            }
            else
            {
                // In the <project> directory.
                path = Path.Combine("..", database);
            }

            path = Path.GetFullPath(path); // Convert to absolute path.
            try
            {
                NorthwindContextLogger.WriteLine($"Database path: {path}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    message: $"{path} not found.",
                    fileName: path
                   );
            }

            optionsBuilder.UseSqlite($"Data Source={path}");

            optionsBuilder.LogTo(NorthwindContextLogger.WriteLine,
            new[] { Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting });
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
