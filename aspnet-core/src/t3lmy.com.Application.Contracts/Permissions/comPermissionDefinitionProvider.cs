using t3lmy.com.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace t3lmy.com.Permissions;

public class comPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(comPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(comPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<comResource>(name);
    }
}
