using Microsoft.EntityFrameworkCore;

namespace web_api_test;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Images> viajefoto { get; set; }
}
