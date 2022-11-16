using GizaSystems.AbpDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace GizaSystems.AbpDemo.Permissions;

public class AbpDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(AbpDemoPermissions.GroupName, L("Permission:BookStore"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        var booksPermission = bookStoreGroup.AddPermission(AbpDemoPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpDemoPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpDemoPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpDemoPermissions.Books.Delete, L("Permission:Books.Delete"));

        // Author
        var authorsPermission = bookStoreGroup.AddPermission(AbpDemoPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(AbpDemoPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(AbpDemoPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(AbpDemoPermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }


    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpDemoResource>(name);
    }
}
