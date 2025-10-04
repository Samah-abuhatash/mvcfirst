using Microsoft.EntityFrameworkCore;

    namespace Session1.Models

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categorys{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Database=MVC12;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tariq 1", description = "First test category" },
                new Category { Id = 2, Name = "Tariq 2", description = "Second test category" },
                new Category { Id = 3, Name = "Tariq 3", description = "Third test category" }
            );
        }

    }
}
