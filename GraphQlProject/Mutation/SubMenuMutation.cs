using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using GraphQlProject.Type;

namespace GraphQlProject.Mutation
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenuService subMenuService)
        {
            Field<SubMenuType>(name: "createSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }), resolve: context =>
            {
                return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
            });
        }
    }
}