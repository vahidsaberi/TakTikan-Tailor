using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TakTikan.Tailor.Configuration;
using TakTikan.Tailor.Web;

namespace TakTikan.Tailor.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TailorDbContextFactory : IDesignTimeDbContextFactory<TailorDbContext>
    {
        public TailorDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TailorDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            TailorDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TailorConsts.ConnectionStringName));

            return new TailorDbContext(builder.Options);
        }
    }
}