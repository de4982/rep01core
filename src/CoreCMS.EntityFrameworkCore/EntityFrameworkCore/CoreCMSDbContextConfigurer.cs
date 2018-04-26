using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreCMS.EntityFrameworkCore
{
    public static class CoreCMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CoreCMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CoreCMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
