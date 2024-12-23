using t3lmy.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace t3lmy.Permissions;

public class t3lmyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(t3lmyPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(t3lmyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<t3lmyResource>(name);
    }
}
