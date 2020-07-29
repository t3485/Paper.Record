using Paper.Record.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Paper.Record.Permissions
{
    public class RecordPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(RecordPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(RecordPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RecordResource>(name);
        }
    }
}
