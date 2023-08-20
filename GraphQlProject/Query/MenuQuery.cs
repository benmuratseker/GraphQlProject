using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Type;

namespace GraphQlProject.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService)
        {
            Field<ListGraphType<MenuType>>("menu", resolve: context => { return menuService.GetMenus(); });
        }
    }
}