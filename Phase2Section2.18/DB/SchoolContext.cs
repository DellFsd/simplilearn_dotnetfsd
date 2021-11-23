using Microsoft.EntityFrameworkCore;

using Phase2Section2._18.Models;

namespace Phase2Section2._18.DB
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() { }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        { }

        public DbSet<StudentModel> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().ToTable("Student");
        }
    }
}
