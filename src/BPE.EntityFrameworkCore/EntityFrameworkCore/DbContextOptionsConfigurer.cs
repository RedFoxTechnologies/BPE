using Microsoft.EntityFrameworkCore;

namespace BPE.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BPEDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BPEDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
