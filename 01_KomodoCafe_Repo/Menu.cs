using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Repo
{
    //POCO
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDesc { get; set; }
        public string ListIngredients { get; set; }
        public double Price { get; set; }
        public Menu() { }
        public Menu(int mealNumber, string mealName, string mealDesc, string listIngredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDesc = mealDesc;
            ListIngredients = listIngredients;
            Price = price;

        }
    }
}
