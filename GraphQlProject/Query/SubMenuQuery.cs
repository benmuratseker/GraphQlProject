using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Type;

namespace GraphQlProject.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenuService subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenus(); });

            Field<ListGraphType<SubMenuType>>("submenu", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }), resolve: context =>
            {
                return subMenuService.GetSubMenus(context.GetArgument<int>("id"));
            });
        }
    }
}