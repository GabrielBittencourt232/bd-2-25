using Imobiliaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Imobiliaria.Data
{
    public class ImobiContext : DbContext
    {
        public ImobiContext(DbContextOptions<ImobiContext> options) : base(options) { }

        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Imovel> Imovel { get; set; }
        public DbSet<ResidenteImovel> StudentCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Residente>().ToTable("Residente");
            modelBuilder.Entity<Imovel>().ToTable("Imovel");
        }
    }
}
