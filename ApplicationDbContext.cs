using Microsoft.EntityFrameworkCore;

namespace web_api_test;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Images> Viajefoto { get; set; }
    public DbSet<UserApplication> UsuarioAplicacion { get; set; }
    public DbSet<AccessUserApplication> AccesoUsuarioAplicacion { get; set; }
    public DbSet<Contact> Contacto { get; set; }
    public DbSet<Installer> Instalador { get; set; }
}
