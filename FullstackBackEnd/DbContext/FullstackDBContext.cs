using FullstackBackEnd.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullstackBackEnd.DbContext
{
    public class FullstackDBContext : IdentityDbContext
    {
        public FullstackDBContext(DbContextOptions<FullstackDBContext> options) : base(options)
        {

        }
        public DbSet<MASGender> MASGenders { get; set; }
        public DbSet<MASCourse> MASCourses { get; set; }
        public DbSet<MASEmployee> MASEmployees { get; set; }
        public DbSet<MAPEmployeeCourse> MAPEmployeeCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
