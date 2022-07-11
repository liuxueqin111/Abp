using my.bookstore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace my.bookstore
{
    [DependsOn(
        typeof(bookstoreEntityFrameworkCoreTestModule)
        )]
    public class bookstoreDomainTestModule : AbpModule
    {

    }
}