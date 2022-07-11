using my.bookstore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace my.bookstore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(bookstoreEntityFrameworkCoreModule),
        typeof(bookstoreApplicationContractsModule)
        )]
    public class bookstoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
