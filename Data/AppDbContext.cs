using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }

   protected override  void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Courses>().HasOne(c => c.student).WithMany().HasForeignKey(s => s.CoursesId);
   }

    public DbSet<Student> Students { get; set; }   
   public DbSet<Courses> Courses { get; set; }
}