using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApp.Model;

namespace StudentApp.Data
{
    public class StudentAppContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
        

        public StudentAppContext (DbContextOptions<StudentAppContext> options)
            : base(options)
        {
        }

        public DbSet<StudentApp.Model.Student> Student { get; set; } = default!;

        public DbSet<StudentApp.Model.Course> Course { get; set; } = default!;
    }
}
