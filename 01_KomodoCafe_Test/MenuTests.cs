using _01_KomodoCafe_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_KomodoCafe_Test
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectNumber()
        {
            Menu item = new Menu();
            item.MealNumber = 1;

            int expected = 1;
            int actual = item.MealNumber;

            Assert.AreEqual(expected, actual);

        }
    }
}
