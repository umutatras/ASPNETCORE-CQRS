using Microsoft.EntityFrameworkCore;

namespace Udemy.CQRS.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student{Name="Umut",Age=25,Surname="Atraş",Id=1},
                new Student{Name="Bedia",Age=23,Surname="Atraş",Id=2},
                new Student{Name="MEhmet",Age=33,Surname="İstanbullu",Id=3},

            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
