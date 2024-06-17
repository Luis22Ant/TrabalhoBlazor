using ApiProjetoEngenharia.Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetoEngenharia.Infra
{

    public class EngenhariaDbContext : DbContext
    {

        public DbSet<Usuario> USUARIOS { get; set; }
        public DbSet<Item> ITENS { get; set; }
        public DbSet<Grupo> GRUPOS { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-215IJJK;Database=EngenhariaProjeto;UID=DESKTOP-215IJJK\\galoc;PWD='';Integrated Security=true;trustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>()
                .Ignore(g => g.Items);

      
        }
    }
}
