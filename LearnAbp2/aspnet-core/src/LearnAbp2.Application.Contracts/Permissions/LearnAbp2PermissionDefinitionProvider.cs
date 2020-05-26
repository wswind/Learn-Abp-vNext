using LearnAbp2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LearnAbp2.Permissions
{
    public class LearnAbp2PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LearnAbp2Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LearnAbp2Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LearnAbp2Resource>(name);
        }
    }
}
