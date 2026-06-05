using Microsoft.EntityFrameworkCore;

namespace Exercise_LinqQueries.EntityModels;

public class NorthwindDb : DbContext
{
    public DbSet<Customer> Customers {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string database = "Northwind.db";
        string dir = Environment.CurrentDirectory;
        string path;

        if (dir.EndsWith("net9.0"))
        {
            path = Path.Combine("..", "..", "..", "..", "LinqWithEFCore", database);
        } else
        {
            path = Path.Combine("..", "LinqWithEFCore", database);
        }

        WriteLine($"Database Path: {path}");
        if (!File.Exists(path))
        {
            throw new FileNotFoundException(message: $"{path} not found.", fileName: path);
        }

        optionsBuilder.UseSqlite($"Data Source={path}");
    }

}
