using GraphQlProject.Models;

namespace GraphQlProject.Interfaces
{
    public interface IMenuService
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);

    }
}