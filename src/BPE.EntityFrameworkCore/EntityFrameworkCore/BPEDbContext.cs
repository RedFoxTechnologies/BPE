using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BPE.EntityFrameworkCore
{
    public class BPEDbContext : AbpDbContext
    {
        public DbSet<Players.Player> Players { get; set; }
        public BPEDbContext(DbContextOptions<BPEDbContext> options) 
            : base(options)
        {

        }
    }
}
