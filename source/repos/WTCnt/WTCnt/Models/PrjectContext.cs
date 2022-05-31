using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTCnt.Models
{
    public class PrjectContext : DbContext
    {
        public PrjectContext(DbContextOptions<PrjectContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Prject> Project { get; set; }
    }
}
