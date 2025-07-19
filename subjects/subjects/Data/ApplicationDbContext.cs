using Microsoft.EntityFrameworkCore;
using subjects.Models;

namespace subjects.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Subject> Subjects { get; set; } = default!;
        public DbSet<Literature> Literatures { get; set; } = default!;
        public DbSet<Author> Authors { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

                // Many-to-Many: Author <-> Literature
            modelBuilder.Entity<Literature>()
                .HasMany(l => l.Authors)
                .WithMany(a => a.Literatures)
                .UsingEntity(j => j.ToTable("AuthorLiterature"));

            // Many-to-Many: Subject <-> Literature
            modelBuilder.Entity<Literature>()
                .HasMany(l => l.Subjects)
                .WithMany(s => s.Literatures)
                .UsingEntity(j => j.ToTable("SubjectLiterature"));
        }
    }
}
