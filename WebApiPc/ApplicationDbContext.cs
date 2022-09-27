using Microsoft.EntityFrameworkCore;
using WebApiPc.Entidades;

namespace WebApiPc
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Computadora> Computadoras { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public object Computadora { get; internal set; }
        public object Marca { get; internal set; }
    }
}
