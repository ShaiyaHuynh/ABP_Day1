using HelloWord.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HelloWord.Permissions;

public class HelloWordPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HelloWordPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HelloWordPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HelloWordResource>(name);
    }
}
