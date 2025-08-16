using Imobiliaria.Models;
using Microsoft.EntityFrameworkCore;
namespace Imobiliaria.Data
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext(DbContextOptions<ImobiliariaContext> options)
            : base(options)
        {
        }

        public DbSet<Imovel> Imoveis
        {
            get; set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imovel>().ToTable("Imovel");
        }

    }

}
