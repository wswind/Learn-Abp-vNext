using Acme.BookStoreSeparateIds.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStoreSeparateIds.Permissions
{
    public class BookStoreSeparateIdsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStoreSeparateIdsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStoreSeparateIdsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreSeparateIdsResource>(name);
        }
    }
}
