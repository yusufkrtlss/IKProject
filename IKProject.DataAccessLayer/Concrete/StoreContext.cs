using IKProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DataAccessLayer.Concrete
{
    public class StoreContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TIRV6AC\\MSSQLSERVER01;Database=IKProject;Trusted_Connection=True;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffMeeting> StaffMeetings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Staff>()
            //.HasOne(s => s.Department)
            //.WithMany(d => d.StaffMembers)
            //.HasForeignKey(s => s.DepartmentId);

            //modelBuilder.Entity<Staff>()
            //    .HasOne(s => s.Meeting)
            //    .WithMany(m => m.StaffMembers)
            //    .HasForeignKey(s => s.MeetingId);

            //modelBuilder.Entity<Comment>()
            //    .HasOne(c => c.Staff)
            //    .WithMany(s => s.Comments)
            //    .HasForeignKey(c => c.StaffId);
            //modelBuilder.Entity<Meeting>()
            //.HasMany(m => m.StaffMembers)
            //.WithOne(s => s.Meeting)
            //.HasForeignKey(s => s.MeetingId);
        }
    }
}
