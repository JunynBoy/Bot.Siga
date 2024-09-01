using Bot.Core.Model;
using Bot.Core.src.Model;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Estudante>? Estudantes { get; set; }
        public DbSet<Materia>? Materias { get; set; }
        public DbSet<Notas>? Notas { get; set; }
        public DbSet<Faltas>? Faltas { get; set; }
        public DbSet<Preferencia>? Preferencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "server=localhost;port=3306;database=siga_automatico;user=root;password=root";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudante>().HasQueryFilter(e => e.DeletedAt == null);
            modelBuilder.Entity<Materia>().HasQueryFilter(m => m.DeletedAt == null);
            modelBuilder.Entity<Notas>().HasQueryFilter(n => n.DeletedAt == null);
            modelBuilder.Entity<Faltas>().HasQueryFilter(f => f.DeletedAt == null);
            modelBuilder.Entity<Preferencia>().HasQueryFilter(p => p.DeletedAt == null);

            // Outras configurações específicas de mapeamento (se houver) podem ser adicionadas aqui.
        }
    }


}
