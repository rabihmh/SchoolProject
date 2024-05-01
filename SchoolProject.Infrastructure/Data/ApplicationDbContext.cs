using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;

namespace SchoolProject.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<DepartmentSubject> DepartmetSubjects { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<StudentSubject> StudentSubjects { get; set; }

    }

}
