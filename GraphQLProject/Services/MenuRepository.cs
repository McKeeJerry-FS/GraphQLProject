using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepository : IMenuRepository
    {
        //private static List<Menu> MenuList = new List<Menu>
        //{
        //    new Menu
        //    {
        //        Id = 1,
        //        Name = "Classic Burger",
        //        Description = "A juicy Cheese Burger with lettuce and tomato",
        //        Price = 10
        //    },
        //    new Menu
        //    {
        //        Id = 2,
        //        Name = "Cheese Pizza",
        //        Description = "A pizza with a garlic butter infused crust, sweet marinara sauce, and a melty mozzarella cheese blend",
        //        Price = 15
        //    },
        //    new Menu
        //    {
        //        Id = 3,
        //        Name = "Chicken Pasta Alfredo",
        //        Description = "A fresh pasta with cheezy alfredo sauce and savory, juicy grilled chicken",
        //        Price = 12
        //    }
        //};

        private GraphQLDbContext dbContext;

        public MenuRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            var menuResult = dbContext.Menus.Find(id);
            dbContext.Menus.Remove(menuResult!);
            dbContext.SaveChanges();
        }

        public List<Menu> GetAllMenu()
        {
            return dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return dbContext.Menus.Find(id)!;
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            var menuResult = dbContext.Menus.Find(id);
            menuResult!.Name = menu.Name;
            menuResult.Description = menu.Description;
            menuResult.Price = menu.Price;
            dbContext.SaveChanges();
            return menu;
        }
    }
}
