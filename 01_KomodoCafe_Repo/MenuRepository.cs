using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Repo
{
    public class MenuRepository
    {
        private List<Menu> _listOfMenu = new List<Menu>();

        //Create
        public void AddItemToMenu(Menu item)
        {
            _listOfMenu.Add(item); 
        }

        //Read
        public List<Menu> GetMenuList()
        {
            return _listOfMenu;
        }

        //Delete
        public bool RemoveItemFromMenu(string name)
        {
            Menu item = GetMenuByName(name);

            if(item == null)
            {
                return false;
            }
            int initialCount = _listOfMenu.Count;
            _listOfMenu.Remove(item);

            if (initialCount > _listOfMenu.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        //HelperMethod
        public Menu GetMenuByName(string name)
        {
            foreach (Menu content in _listOfMenu)
            {
                if (content.MealName == name)
                {
                    return content;
                }
            }
            return null;
        }
    }
}
