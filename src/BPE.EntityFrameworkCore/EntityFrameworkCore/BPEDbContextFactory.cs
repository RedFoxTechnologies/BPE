using BPE.Configuration;
using BPE.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace BPE.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BPEDbContextFactory : IDbContextFactory<BPEDbContext>
    {
        public BPEDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<BPEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder, 
                configuration.GetConnectionString(BPEConsts.ConnectionStringName)
                );

            return new BPEDbContext(builder.Options);
        }
    }
}