using Microsoft.EntityFrameworkCore;

using Core;

namespace Infrastructure;

public class MovieDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbPassword = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");
        var dbName = Environment.GetEnvironmentVariable("POSTGRES_DB");
        optionsBuilder.UseNpgsql(
            $"Host=db;User ID=postgres;Password={dbPassword};Database={dbName}"
        ).UseSnakeCaseNamingConvention();
    }

    public MovieDbContext(DbContextOptions<MovieDbContext> options)
        : base(options) { }

    public MovieDbContext() { }
}
