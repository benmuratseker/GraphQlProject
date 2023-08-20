using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Services
{
    public class MenuService : IMenuService
    {
        private readonly GraphQlDbContext dbContext;

        public MenuService(GraphQlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Menu AddMenu(Menu menu)
        {
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
            return dbContext.Menus.ToList();
        }
    }
}