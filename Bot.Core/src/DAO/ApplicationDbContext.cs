using Bot.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class ApplicationDbContext : DbContext
        {

            public DbSet<Estudante>? Estudantes { get; set; }
            public DbSet<MateriaMatriculado>? MateriasMatriculadas { get; set; }
            public DbSet<Notas>? Notas { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                string connectionString = "server=localhost;port=3306;database=auto_siga;user=root;password=root";
                //string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Nota>().HasKey(x => new { x.MateriaId, x.AlunoId });
            //modelBuilder.Entity<Nota>().HasOne(po => po.Materia).WithMany(p => p.Notas).HasForeignKey(po => po.MateriaId);
            //modelBuilder.Entity<Nota>().HasOne(po => po.Estudante).WithMany(p => p.Notas).HasForeignKey(po => po.AlunoId);


            modelBuilder.Entity<Estudante>().HasQueryFilter(r => r.DeletedAt == null);

            modelBuilder.Entity<MateriaMatriculado>().HasQueryFilter(r => r.DeletedAt == null);

            modelBuilder.Entity<Notas>().HasQueryFilter(r => r.DeletedAt == null);
        }

        

    }
    
}
