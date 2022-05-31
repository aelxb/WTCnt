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
        public DbSet<Usr> User { get; set; }
    }
}
