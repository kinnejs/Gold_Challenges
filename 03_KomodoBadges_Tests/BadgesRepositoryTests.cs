using _03_KomodoBadges_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_KomodoBadges_Tests
{
    [TestClass]
    public class BadgesRepositoryTests
    {
        private BadgesRepository _repo;
        private Badges _badge; 
        

        [TestInitialize]
        public void Arrange()
        {
            _repo = new BadgesRepository();
            List<string> _list = new List<string> { "A1", "A2", "A3" };
            _badge = new Badges(123, _list);

            _repo.AddBadge(_badge);

        }

        //Add Badge
        [TestMethod]
        public void AddBadge_ShouldGetNotNull()
        {
            //Arrange

            //Act
            List<string> badgeFromDirectory = _repo.GetAccessByBadge(123);

            //Assert
            Assert.IsNotNull(badgeFromDirectory);
        }

        [TestMethod]
        public void RemoveDoor_ShouldReturnFalse()
        {
            //Arrange
            _repo.RemoveDoor(123, "A1");
            List<string> doorFromBadge = _repo.GetAccessByBadge(123);
            //Act
            Assert.IsFalse(doorFromBadge.Contains("A1"));
        }

        [TestMethod]
        public void AddDoor_ShouldReturnTrue()
        {
            //Arrange
            _repo.AddDoor(123, "F17");
            List<string> doorFromBadge = _repo.GetAccessByBadge(123);
            //Act
            Assert.IsTrue(doorFromBadge.Contains("F17"));
        }
    }
}
