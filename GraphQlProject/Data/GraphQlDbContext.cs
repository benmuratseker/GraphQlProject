using GraphQlProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlProject.Data
{
    public class GraphQlDbContext : DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options) :base(options)
        {
            
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}