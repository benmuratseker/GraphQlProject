using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Services
{
    public class SubMenuService : ISubMenuService
    {
        private readonly GraphQlDbContext dbContext;

        public SubMenuService(GraphQlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            dbContext.SubMenus.Add(subMenu);
            dbContext.SaveChanges();
            return subMenu;
        }

        public List<SubMenu> GetSubMenus()
        {
            return dbContext.SubMenus.ToList();
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return dbContext.SubMenus.Where(m => m.MenuId == menuId).ToList();
        }
    }
}