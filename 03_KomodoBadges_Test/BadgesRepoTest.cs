using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_KomodoBadges_Test
{
    [TestClass]
    public class BadgesRepoTest
    {
        private BadgesRepository _repo;
        private Badges _badges;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new BadgesRepository();
            _badges = new Badges(123, )
        }

        [TestMethod]
        public void AddBadge_ShouldGetNotNull()
        {
            //Arrange
            Badges badge = new Badges();
            badge.BadgeID = 123;
            BadgesRepository repo = new BadgesRepository();

            //Act
            repo.AddBadge(badge);
            Badges badgeFromDirectory = repo.

            //Assert
            Assert.IsNotNull(badgeFromDirectory);
        }
    }
}
