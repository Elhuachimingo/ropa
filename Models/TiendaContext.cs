using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ropa.Models
{
    public class TiendaContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }

    }
}