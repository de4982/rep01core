using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CoreCMS.Configuration;
using CoreCMS.Web;

namespace CoreCMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CoreCMSDbContextFactory : IDesignTimeDbContextFactory<CoreCMSDbContext>
    {
        public CoreCMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreCMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CoreCMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CoreCMSConsts.ConnectionStringName));

            return new CoreCMSDbContext(builder.Options);
        }
    }
}
