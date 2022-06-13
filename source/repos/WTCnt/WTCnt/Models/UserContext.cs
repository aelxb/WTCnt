using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class UsrContext : DbContext
    {
        public UsrContext(DbContextOptions<UsrContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public UsrContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D4676LU\sqlexpress;Initial Catalog=WorktimeControl;Integrated Security=True");
        }
        public DbSet<Usr> User { get; set; }
    }
}
