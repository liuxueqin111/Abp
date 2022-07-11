using Volo.Abp.Modularity;

namespace my.bookstore
{
    [DependsOn(
        typeof(bookstoreApplicationModule),
        typeof(bookstoreDomainTestModule)
        )]
    public class bookstoreApplicationTestModule : AbpModule
    {

    }
}