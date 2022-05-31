using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class ProjectPerTaskContext : DbContext
    {
        public ProjectPerTaskContext(DbContextOptions<ProjectPerTaskContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ProjectPerTask> ProjectPerTasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectPerTask>().HasKey(u => new { u.ID_project, u.ID_Task });
        }
    }
}
