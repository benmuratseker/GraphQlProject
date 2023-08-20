using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenuService subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            //to bring submenus with menus
            Field<ListGraphType<SubMenuType>>(name: "submenus", resolve: context =>
            {
                return subMenuService.GetSubMenus(context.Source.Id);
            });
        }
    }
}