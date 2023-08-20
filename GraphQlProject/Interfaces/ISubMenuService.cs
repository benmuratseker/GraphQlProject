using GraphQlProject.Models;

namespace GraphQlProject.Interfaces
{
    public interface ISubMenuService
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}