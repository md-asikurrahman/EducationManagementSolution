using Microsoft.EntityFrameworkCore;
using EducationManagementSolution.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EducationManagementSolution.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
            
    }
    DbSet<ApplicationUser> ApplicationUsers { get; set; }
    DbSet<AcademicQualification> AcademicQualifications { get; set; }
    DbSet<AcademicSession> AcademicSessions { get; set; }
    DbSet<Address> Addresses { get; set; }
    DbSet<ClassList> ClassLists { get; set; }
    DbSet<Department> Departments { get; set; }
    DbSet<Designation> Designations { get; set; }
    DbSet<EducationLevel> EducationLevels { get; set; }
    DbSet<Employee> Employees { get; set; }
    DbSet<Student> Students { get; set; }
    //DbSet<StudentClass> StudentClasses { get; set; }
    DbSet<Subject> Subjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Hardcoded connection string
        optionsBuilder.UseSqlServer("Server=DESKTOP-4AQFFCU;Database=EducationSystem_Db;User=sa;Password=123456;MultipleActiveResultSets=true;TrustServerCertificate=true");
    }

}
