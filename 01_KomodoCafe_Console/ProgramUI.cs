using _01_KomodoCafe_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Console
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();

        //Method that starts Application
        public void Run()
        {
            SeedContent();
            ConsoleMenu();
        }

        //Menu
        private void ConsoleMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display Options to User
                Console.WriteLine("Select an Option:\n" +
                    "1. Create a New Menu Item\n" +
                    "2. View all Menu Items\n" +
                    "3. Delete Menu Item\n" +
                    "0. Exit");

                //Get user input
                string input = Console.ReadLine();

                //Evaluate input
                switch(input)
                {
                    case "1":
                        CreateMenuItem();
                        break;
                    case "2":
                        ViewMenuItems();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    case "0":
                        Console.WriteLine("Have a Great Day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number!");
                        break;
                }
                Console.WriteLine("\nPlease Press any Key to Continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void  SeedContent()
        {
            Menu bigMac = new Menu(1, "BigMac", "Two all beef patties, lettuce cheese, special sauce on a sesame seed bun", "Beef, cheese, lettuce, onions, pickles, special sauce, bun", 3.99);
            Menu whopper = new Menu(2, "Whopper", "Flame grilled angus beef with topped with the works", "Beef, cheese, lettuce, tomato, onion, pickle, ketchup, mustard, bun", 4.99);
            Menu pizza = new Menu(3, "Pizza", "Slice of New York style pizza made with the toppings you want", "Dough, cheese, pepperoni, sausage, onion, green pepper", 2.99);
            Menu taco = new Menu(4, "Taco", "Double decker taco filled with your choice of chicken or beef", "Beef/Chicken, cheese, lettuce, beans, tomatos, tortilla, salsa", 1.99);

            _menuRepo.AddItemToMenu(bigMac);
            _menuRepo.AddItemToMenu(whopper);
            _menuRepo.AddItemToMenu(pizza);
            _menuRepo.AddItemToMenu(taco);
        }

        private void CreateMenuItem()
        {
            Console.Clear();
            Menu newItem = new Menu();
            
            //MealNumber
            Console.WriteLine("Enter the Meal Number:");
            string mealNumberAsString = Console.ReadLine();
            int mealNumberAsInt = int.Parse(mealNumberAsString);
            newItem.MealNumber = mealNumberAsInt;

            //MealName
            Console.WriteLine("Enter the Meal Name:");
            newItem.MealName = Console.ReadLine().ToLower();

            //MealDesc
            Console.WriteLine("Enter the Meal Description:");
            newItem.MealDesc = Console.ReadLine();

            //List Of Ingredients
            Console.WriteLine("Enter the List of Ingredients:");
            newItem.ListIngredients = Console.ReadLine();

            //Price
            Console.WriteLine("Enter the Price:");
            string priceAsString = Console.ReadLine();
            double priceAsDouble = double.Parse(priceAsString);
            newItem.Price = priceAsDouble;

            _menuRepo.AddItemToMenu(newItem);
        }

        private void ViewMenuItems()
        {
            Console.Clear();
            List<Menu> listOfMenu = _menuRepo.GetMenuList();
            foreach(Menu content in listOfMenu)
            {
                Console.WriteLine($"# {content.MealNumber}\n" +
                    $"Name: {content.MealName}\n" +
                    $"Price: {content.Price}");
            }
        }

        private void DeleteMenuItem()
        {
            ViewMenuItems();
            //Get number to delete
            Console.WriteLine("\nEnter the Name of the Item you want to Remove:");
            string name = Console.ReadLine().ToLower();

            bool wasDeleted = _menuRepo.RemoveItemFromMenu(name);
           
            if(wasDeleted)
            {
                Console.WriteLine("The Item was Successfully Removed");
            }
            else
            {
                Console.WriteLine("The Item COULD NOT be Removed");
            }
        }
    }
}
