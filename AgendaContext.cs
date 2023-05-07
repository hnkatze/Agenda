using agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace agenda;
//conexion a la base de datos
public class AgendaContext : DbContext
{
    public DbSet<CodigoArea> ?CodigoAreas { get; set; }
    public DbSet<Telefono> ?Telefono { get; set; }
    public DbSet<Persona> ?Persona { get; set; }

    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
    }
}
