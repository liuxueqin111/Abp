using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace my.bookstore
{
    [Dependency(ReplaceServices = true)]
    public class bookstoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "bookstore";
    }
}
