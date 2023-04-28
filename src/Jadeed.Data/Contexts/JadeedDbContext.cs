using Jadeed.Domain.Entities;
using Jadeed.Domain.Entities.Education;
using Jadeed.Domain.Entities.Finance;
using Jadeed.Domain.Entities.Management;
using Jadeed.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Jadeed.Data.Contexts
{
    public class JadeedDbContext : DbContext
    {
        public JadeedDbContext(DbContextOptions<JadeedDbContext> options)
            : base(options)
        {
        }

        // Education
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<LessonDay> LessonDays { get; set; }
        public DbSet<StudentAttendence> StudentAttendences { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        // Finance
        public DbSet<Payment> Payments { get; set; }

        // Management
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Room> Rooms { get; set; }

        // Users
        public DbSet<TeacherDetail> Teachers { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
