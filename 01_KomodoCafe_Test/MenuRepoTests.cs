using _01_KomodoCafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_KomodoCafe_Test
{
    [TestClass]
    public class MenuRepoTests
    {
        private MenuRepository _repo;
        private Menu _menu;
        
        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _menu = new Menu(1, "BigMac", "Secret Sauce", "Lettuce, Onion, Cheese, Meat, Pickle, Bun", 5.00);

            _repo.AddItemToMenu(_menu);
        }


        //Add Method
        [TestMethod]
        public void AddItemToMenu_ShouldBeNotNull()
        {
            //Arrange
            Menu item = new Menu();
            item.MealName = "BigMac"; 
            MenuRepository repo = new MenuRepository();

            //Act
            repo.AddItemToMenu(item);
            Menu itemFromDir = repo.GetMenuByName("BigMac");
            
            //Assert
            Assert.IsNotNull(itemFromDir);
        }

        //Read Method
        [TestMethod]
        public void DeleteItem_ShouldReturnTrue()
        {
            //Act
            bool deleteResult = _repo.RemoveItemFromMenu(_menu.MealName);

            //Assert
            Assert.IsTrue(deleteResult);
        }
    }
}
