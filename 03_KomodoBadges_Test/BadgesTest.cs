using _03_KomodoBadges_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_KomodoBadges_Test
{
    [TestClass]
    public class BadgesTest
    {
        [TestMethod]
        public void SetBadgeID_ShouldSetCorrectInt()
        {
            //Assert
            Badges badge = new Badges();
            badge.BadgeID = 151;

            //Act
            int act = badge.BadgeID;
            int exp = 151;

            //Assert
            Assert.AreEqual(exp, act);
        }
    }
}
