using my.bookstore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace my.bookstore.Permissions
{
    public class bookstorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(bookstorePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(bookstorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<bookstoreResource>(name);
        }
    }
}
