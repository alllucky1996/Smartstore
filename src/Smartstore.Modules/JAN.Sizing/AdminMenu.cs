using System.Linq;
using JAN.Sizing.Extensions;
using Smartstore.Collections;
using Smartstore.Core.Content.Menus;
using Smartstore.Core.Localization;
using Smartstore.Web.Rendering.Builders;

namespace JAN.Sizing
{
    public class AdminMenu : AdminMenuProvider
    {
        public Localizer T { get; set; } = NullLocalizer.Instance;

        protected override void BuildMenuCore(TreeNode<MenuItem> modulesNode)
        {
            var keepMenu = modulesNode.Root.Children.Where(e => (string)e.Id == "users" || (string)e.Id == "modules").Select(s => s.Clone(true)).ToList();
            modulesNode.Root.Clear();
            foreach (var item in keepMenu)
            {
                modulesNode.Root.Append(item);
            }

            var menuNote = new TreeNode<MenuItem>(new MenuItem().ToBuilder()
                        .ResKey("Plugins.JAN.Sizing.MaserData").Icon("icm icm-cube").Id("ctg")
                        .PermissionNames(SizingPermissions.MasterData.Size.Read)
                        .AsItem());
            menuNote.Append(new MenuItem().ToBuilder()
                .ResKey("Plugins.JAN.Sizing.MaserData.Size")
                .Icon("tags", "bi")
                .PermissionNames(SizingPermissions.MasterData.Size.Read)
                .Action("List", "Size", new { area = "Admin" })
                .AsItem());
            menuNote.Append(new MenuItem().ToBuilder()
               .ResKey("Plugins.JAN.Sizing.MaserData.DonVi")
               .Icon("tags", "bi")
               .PermissionNames(SizingPermissions.MasterData.DonVi.Read)
               .Action("List", "Size", new { area = "Admin" })
               .AsItem());

            modulesNode.Root.Append(menuNote);
        }
    }
}
