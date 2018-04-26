using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CoreCMS.Authorization.Roles;
using CoreCMS.Authorization.Users;
using CoreCMS.MultiTenancy;

namespace CoreCMS.EntityFrameworkCore
{
    public class CoreCMSDbContext : AbpZeroDbContext<Tenant, Role, User, CoreCMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CoreCMSDbContext(DbContextOptions<CoreCMSDbContext> options)
            : base(options)
        {
        }
    }
}
