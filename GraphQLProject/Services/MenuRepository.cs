using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepository : IMenuRepository
    {
        private static List<Menu> MenuList = new List<Menu>
        {
            new Menu
            {
                Id = 1,
                Name = "Classic Burger",
                Description = "A juicy Cheese Burger with lettuce and tomato",
                Price = 10
            },
            new Menu
            {
                Id = 2,
                Name = "Cheese Pizza",
                Description = "A pizza with a garlic butter infused crust, sweet marinara sauce, and a melty mozzarella cheese blend",
                Price = 15
            },
            new Menu
            {
                Id = 3,
                Name = "Chicken Pasta Alfredo",
                Description = "A fresh pasta with cheezy alfredo sauce and savory, juicy grilled chicken",
                Price = 12
            }
        };

        public Menu AddMenu(Menu menu)
        {
            MenuList.Add(menu);
            return menu;
        }

        public void DeleteMenu(int id)
        {
            MenuList.RemoveAt(id);

        }

        public List<Menu> GetAllMenu()
        {
            return MenuList;
        }

        public Menu GetMenuById(int id)
        {
            return MenuList.Find(m => m.Id == id)!;
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            MenuList[id] = menu;
            return menu;
        }
    }
}
